using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "TopicSelect", columnHash: 0xc312c89f )]
    public class TopicSelect : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT


        // col: 00 offset: 0000
        public string Name;

        // col: 04 offset: 0004
        public uint[] unknown4;

        // col: 03 offset: 002c
        public ushort unknown2c;

        // col: 02 offset: 002e
        public byte unknown2e;

        // col: 01 offset: 002f
        private byte packed2f;
        public bool packed2f_1 => ( packed2f & 0x1 ) == 0x1;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Name = parser.ReadOffset< string >( 0x0 );

            // col: 4 offset: 0004
            unknown4 = new uint[10];
            unknown4[0] = parser.ReadOffset< uint >( 0x4 );
            unknown4[1] = parser.ReadOffset< uint >( 0x8 );
            unknown4[2] = parser.ReadOffset< uint >( 0xc );
            unknown4[3] = parser.ReadOffset< uint >( 0x10 );
            unknown4[4] = parser.ReadOffset< uint >( 0x14 );
            unknown4[5] = parser.ReadOffset< uint >( 0x18 );
            unknown4[6] = parser.ReadOffset< uint >( 0x1c );
            unknown4[7] = parser.ReadOffset< uint >( 0x20 );
            unknown4[8] = parser.ReadOffset< uint >( 0x24 );
            unknown4[9] = parser.ReadOffset< uint >( 0x28 );

            // col: 3 offset: 002c
            unknown2c = parser.ReadOffset< ushort >( 0x2c );

            // col: 2 offset: 002e
            unknown2e = parser.ReadOffset< byte >( 0x2e );

            // col: 1 offset: 002f
            packed2f = parser.ReadOffset< byte >( 0x2f, ExcelColumnDataType.UInt8 );


        }
    }
}