using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "ChocoboRaceWeather", columnHash: 0xfaedad07 )]
    public class ChocoboRaceWeather : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT


        // col: 00 offset: 0000
        public int WeatherType1;

        // col: 01 offset: 0004
        public int WeatherType2;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 0 offset: 0000
            WeatherType1 = parser.ReadOffset< int >( 0x0 );

            // col: 1 offset: 0004
            WeatherType2 = parser.ReadOffset< int >( 0x4 );


        }
    }
}