using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "HWDInfoBoardArticleType", columnHash: 0xdebb20e3 )]
    public class HWDInfoBoardArticleType : IExcelRow
    {
        // column defs from Wed, 15 Jan 2020 17:17:16 GMT


        // col: 00 offset: 0000
        public string Type;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Type = parser.ReadOffset< string >( 0x0 );


        }
    }
}