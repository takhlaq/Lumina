using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "GuidePageString", columnHash: 0xdebb20e3 )]
    public class GuidePageString : IExcelRow
    {
        // column defs from Mon, 15 Jul 2019 14:22:54 GMT


        // col: 00 offset: 0000
        public string String;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            String = parser.ReadOffset< string >( 0x0 );


        }
    }
}