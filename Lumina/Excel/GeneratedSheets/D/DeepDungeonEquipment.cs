using Lumina.Data.Structs.Excel;

namespace Lumina.Excel.GeneratedSheets
{
    [Sheet( "DeepDungeonEquipment", columnHash: 0xc638f2bf )]
    public class DeepDungeonEquipment : IExcelRow
    {
        // column defs from Sat, 15 Jun 2019 16:05:03 GMT


        // col: 01 offset: 0000
        public string Singular;

        // col: 03 offset: 0004
        public string Plural;

        // col: 09 offset: 0008
        public string Name;

        // col: 10 offset: 000c
        public string Description;

        // col: 02 offset: 0010
        public sbyte Adjective;

        // col: 04 offset: 0011
        public sbyte PossessivePronoun;

        // col: 05 offset: 0012
        public sbyte StartsWithVowel;

        // col: 06 offset: 0013
        public sbyte unknown13;

        // col: 07 offset: 0014
        public sbyte Pronoun;

        // col: 08 offset: 0015
        public sbyte Article;

        // col: 00 offset: 0018
        public uint Icon;


        public int RowId { get; set; }
        public int SubRowId { get; set; }

        public void PopulateData( RowParser parser, Lumina lumina )
        {
            RowId = parser.Row;
            SubRowId = parser.SubRow;

            // col: 1 offset: 0000
            Singular = parser.ReadOffset< string >( 0x0 );

            // col: 3 offset: 0004
            Plural = parser.ReadOffset< string >( 0x4 );

            // col: 9 offset: 0008
            Name = parser.ReadOffset< string >( 0x8 );

            // col: 10 offset: 000c
            Description = parser.ReadOffset< string >( 0xc );

            // col: 2 offset: 0010
            Adjective = parser.ReadOffset< sbyte >( 0x10 );

            // col: 4 offset: 0011
            PossessivePronoun = parser.ReadOffset< sbyte >( 0x11 );

            // col: 5 offset: 0012
            StartsWithVowel = parser.ReadOffset< sbyte >( 0x12 );

            // col: 6 offset: 0013
            unknown13 = parser.ReadOffset< sbyte >( 0x13 );

            // col: 7 offset: 0014
            Pronoun = parser.ReadOffset< sbyte >( 0x14 );

            // col: 8 offset: 0015
            Article = parser.ReadOffset< sbyte >( 0x15 );

            // col: 0 offset: 0018
            Icon = parser.ReadOffset< uint >( 0x18 );


        }
    }
}