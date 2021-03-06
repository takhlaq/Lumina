using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "Balloon", columnHash: 0x9d1b5f4b )]
    public class Balloon : IExcelRow
    {
        // column defs from Wed, 15 Jan 2020 17:17:16 GMT


        // col: 01 offset: 0000
        public string Dialogue;

        // col: 00 offset: 0004
        private byte packed4;
        public bool Slowly => ( packed4 & 0x1 ) == 0x1;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 1 offset: 0000
            Dialogue = parser.ReadOffset< string >( 0x0 );

            // col: 0 offset: 0004
            packed4 = parser.ReadOffset< byte >( 0x4, ExcelColumnDataType.UInt8 );


        }
    }
}