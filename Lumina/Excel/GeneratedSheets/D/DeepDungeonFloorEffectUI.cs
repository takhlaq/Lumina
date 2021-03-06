using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DeepDungeonFloorEffectUI", columnHash: 0x11a44a12 )]
    public class DeepDungeonFloorEffectUI : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT


        // col: 01 offset: 0000
        public string Name;

        // col: 02 offset: 0004
        public string Description;

        // col: 00 offset: 0008
        public uint Icon;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 1 offset: 0000
            Name = parser.ReadOffset< string >( 0x0 );

            // col: 2 offset: 0004
            Description = parser.ReadOffset< string >( 0x4 );

            // col: 0 offset: 0008
            Icon = parser.ReadOffset< uint >( 0x8 );


        }
    }
}