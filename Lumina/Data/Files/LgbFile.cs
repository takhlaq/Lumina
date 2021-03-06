using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Lumina.Data.Parsing.Layer;
using Lumina.Extensions;

// field assigned but not read warning
#pragma warning disable 414

namespace Lumina.Data.Files
{
    public class LgbFile : FileResource
    {
        public struct FileHeader
        {
            char[] FileID; //[4]
            int FileSize;
            int TotalChunkCount;

            public static FileHeader Read( BinaryReader br )
            {
                return new FileHeader
                {
                    FileID = br.ReadChars( 4 ), FileSize = br.ReadInt32(), TotalChunkCount = br.ReadInt32()
                };
            }
        }

        public FileHeader Header { get; private set; }
        public LayerCommon.LayerChunk ChunkHeader { get; private set; }
        public LayerCommon.Layer[] Layers { get; private set; }

        public override void LoadFile()
        {
            Header = FileHeader.Read( Reader );
            ChunkHeader = LayerCommon.LayerChunk.Read( Reader );
            Layers = new LayerCommon.Layer[ChunkHeader.LayersCount];

            long start = FileStream.Position;
            var layerOffsets = Reader.ReadStructures< Int32 >( ChunkHeader.LayersCount );

            for( int i = 0; i < ChunkHeader.LayersCount; i++ )
            {
                FileStream.Position = start + layerOffsets[ i ];
                Layers[ i ] = LayerCommon.Layer.Read( Reader );
            }
        }
    }
}
