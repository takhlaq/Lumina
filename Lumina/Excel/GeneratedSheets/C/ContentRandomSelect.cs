using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ContentRandomSelect", columnHash: 0xd870e208 )]
    public class ContentRandomSelect : IExcelRow
    {
        // column defs from Mon, 15 Jul 2019 14:22:54 GMT


        // col: 00 offset: 0000
        public ushort Name;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Name = parser.ReadOffset< ushort >( 0x0 );


        }
    }
}