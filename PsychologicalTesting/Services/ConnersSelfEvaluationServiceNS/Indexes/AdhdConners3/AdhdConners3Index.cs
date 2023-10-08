namespace PsychologicalTesting;

public class AdhdConners3Index
{
    public List<KeyValuePair<byte, byte>> Items { get; set; }

    public byte TotalScore => (byte)Items.Sum(x => x.Value);

    public byte Probability
    {
        get
        {
            switch (TotalScore)
            {
                case 0: return 26;
                case 1: return 35;
                case 2: return 44;
                case 3: return 52;
                case 4: return 59;
                case 5: return 66;
                case 6: return 73;
                case 7: return 78;
                case 8: return 83;
                case 9: return 87;
                case 10: return 91;
                case 11: return 94;
                case 12: return 96;
                case 13: return 97;
                case 14: return 98;
                case 15: return 98;
                case 16: return 99;
                case 17: return 99;
                case 18: return 99;

                default: return 0;
            }
        }
    }
}
