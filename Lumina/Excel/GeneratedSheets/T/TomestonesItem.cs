using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "TomestonesItem", columnHash: 0xc8901190 )]
    public class TomestonesItem : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT


        // col: 00 offset: 0000
        public int Item;

        // col: 02 offset: 0004
        public int Tomestones;

        // col: 01 offset: 0008
        public sbyte unknown8;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            Item = parser.ReadOffset< int >( 0x0 );

            // col: 2 offset: 0004
            Tomestones = parser.ReadOffset< int >( 0x4 );

            // col: 1 offset: 0008
            unknown8 = parser.ReadOffset< sbyte >( 0x8 );


        }
    }
}