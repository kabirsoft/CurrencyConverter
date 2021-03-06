using Microsoft.EntityFrameworkCore.Migrations;

namespace CurrencyConverter.Migrations
{
    public partial class CreateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Currencies",
                columns: table => new
                {
                    timestamp = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    @base = table.Column<string>(name: "base", type: "nvarchar(max)", nullable: true),
                    date = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currencies", x => x.timestamp);
                });

            migrationBuilder.CreateTable(
                name: "Rates",
                columns: table => new
                {
                    timestamp = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AED = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    AFN = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    ALL = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    AMD = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    ANG = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    AOA = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    ARS = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    AUD = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    AWG = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    AZN = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    BAM = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    BBD = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    BDT = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    BGN = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    BHD = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    BIF = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    BMD = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    BND = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    BOB = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    BRL = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    BSD = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    BTC = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    BTN = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    BWP = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    BYN = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    BYR = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    BZD = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    CAD = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    CDF = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    CHF = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    CLF = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    CLP = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    CNY = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    COP = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    CRC = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    CUC = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    CUP = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    CVE = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    CZK = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    DJF = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    DKK = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    DOP = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    DZD = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    EGP = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    ERN = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    ETB = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    EUR = table.Column<int>(type: "int", nullable: false),
                    FJD = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    FKP = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    GBP = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    GEL = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    GGP = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    GHS = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    GIP = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    GMD = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    GNF = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    GTQ = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    GYD = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    HKD = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    HNL = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    HRK = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    HTG = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    HUF = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    IDR = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    ILS = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    IMP = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    INR = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    IQD = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    IRR = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    ISK = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    JEP = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    JMD = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    JOD = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    JPY = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    KES = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    KGS = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    KHR = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    KMF = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    KPW = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    KRW = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    KWD = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    KYD = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    KZT = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    LAK = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    LBP = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    LKR = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    LRD = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    LSL = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    LTL = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    LVL = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    LYD = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    MAD = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    MDL = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    MGA = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    MKD = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    MMK = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    MNT = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    MOP = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    MRO = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    MUR = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    MVR = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    MWK = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    MXN = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    MYR = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    MZN = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    NAD = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    NGN = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    NIO = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    NOK = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    NPR = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    NZD = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    OMR = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    PAB = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    PEN = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    PGK = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    PHP = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    PKR = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    PLN = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    PYG = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    QAR = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    RON = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    RSD = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    RUB = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    RWF = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    SAR = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    SBD = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    SCR = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    SDG = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    SEK = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    SGD = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    SHP = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    SLL = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    SOS = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    SRD = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    STD = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    SVC = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    SYP = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    SZL = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    THB = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    TJS = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    TMT = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    TND = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    TOP = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    TRY = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    TTD = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    TWD = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    TZS = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    UAH = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    UGX = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    USD = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    UYU = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    UZS = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    VEF = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    VND = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    VUV = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    WST = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    XAF = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    XAG = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    XAU = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    XCD = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    XDR = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    XOF = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    XPF = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    YER = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    ZAR = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    ZMK = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    ZMW = table.Column<decimal>(type: "decimal(18,6)", nullable: false),
                    ZWL = table.Column<decimal>(type: "decimal(18,6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rates", x => x.timestamp);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Currencies");

            migrationBuilder.DropTable(
                name: "Rates");
        }
    }
}
