using Newtonsoft.Json;

namespace WAF.Models.files
{
    public class ResultDTO
    {
        public Meta meta { get; set; }
        public Data data { get; set; }
    }
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class AdAware
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class AhnLabV3
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class Alibaba
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class ALYac
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class AntiyAVL
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class Arcabit
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class Attributes
    {
        public int date { get; set; }
        public string status { get; set; }
        public Stats stats { get; set; }
        public Results results { get; set; }
    }

    public class Avast
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class AVG
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class Avira
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class AVware
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class Baidu
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class BitDefender
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class Bkav
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class CATQuickHeal
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class ClamAV
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class CMC
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class Comodo
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class Cyren
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class Data
    {
        public Attributes attributes { get; set; }
        public string type { get; set; }
        public string id { get; set; }
        public Links links { get; set; }
    }

    public class DrWeb
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class Emsisoft
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class ESETNOD32
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class FileInfo
    {
        public int size { get; set; }
        public string sha1 { get; set; }
        public string sha256 { get; set; }
        public string md5 { get; set; }
    }

    public class Fortinet
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class FProt
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class FSecure
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class GData
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class Ikarus
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class Jiangmin
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class K7AntiVirus
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class K7GW
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class Kaspersky
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class Kingsoft
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class Links
    {
        public string item { get; set; }
        public string self { get; set; }
    }

    public class Lionic
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class Malwarebytes
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class McAfee
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class McAfeeGWEdition
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class Meta
    {
        public FileInfo file_info { get; set; }
    }

    public class Microsoft
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class MicroWorldEScan
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class NANOAntivirus
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class NProtect
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class Panda
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class Qihoo360
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class Results
    {
        public Bkav Bkav { get; set; }
        public Lionic Lionic { get; set; }

        [JsonProperty("MicroWorld-eScan")]
        public MicroWorldEScan MicroWorldeScan { get; set; }
        public NProtect nProtect { get; set; }
        public CMC CMC { get; set; }

        [JsonProperty("CAT-QuickHeal")]
        public CATQuickHeal CATQuickHeal { get; set; }
        public McAfee McAfee { get; set; }
        public Malwarebytes Malwarebytes { get; set; }
        public Zillya Zillya { get; set; }
        public TheHacker TheHacker { get; set; }
        public BitDefender BitDefender { get; set; }
        public K7GW K7GW { get; set; }
        public K7AntiVirus K7AntiVirus { get; set; }
        public Baidu Baidu { get; set; }

        [JsonProperty("F-Prot")]
        public FProt FProt { get; set; }
        public Symantec Symantec { get; set; }

        [JsonProperty("ESET-NOD32")]
        public ESETNOD32 ESETNOD32 { get; set; }

        [JsonProperty("TrendMicro-HouseCall")]
        public TrendMicroHouseCall TrendMicroHouseCall { get; set; }
        public Avast Avast { get; set; }
        public ClamAV ClamAV { get; set; }
        public GData GData { get; set; }
        public Kaspersky Kaspersky { get; set; }
        public Alibaba Alibaba { get; set; }

        [JsonProperty("NANO-Antivirus")]
        public NANOAntivirus NANOAntivirus { get; set; }
        public ViRobot ViRobot { get; set; }
        public Rising Rising { get; set; }

        [JsonProperty("Ad-Aware")]
        public AdAware AdAware { get; set; }
        public Sophos Sophos { get; set; }
        public Comodo Comodo { get; set; }

        [JsonProperty("F-Secure")]
        public FSecure FSecure { get; set; }
        public DrWeb DrWeb { get; set; }
        public VIPRE VIPRE { get; set; }
        public TrendMicro TrendMicro { get; set; }

        [JsonProperty("McAfee-GW-Edition")]
        public McAfeeGWEdition McAfeeGWEdition { get; set; }
        public Emsisoft Emsisoft { get; set; }
        public Cyren Cyren { get; set; }
        public Jiangmin Jiangmin { get; set; }
        public Avira Avira { get; set; }

        [JsonProperty("Antiy-AVL")]
        public AntiyAVL AntiyAVL { get; set; }
        public Kingsoft Kingsoft { get; set; }
        public Arcabit Arcabit { get; set; }
        public SUPERAntiSpyware SUPERAntiSpyware { get; set; }
        public Microsoft Microsoft { get; set; }

        [JsonProperty("AhnLab-V3")]
        public AhnLabV3 AhnLabV3 { get; set; }
        public ALYac ALYac { get; set; }
        public AVware AVware { get; set; }
        public VBA32 VBA32 { get; set; }
        public Zoner Zoner { get; set; }
        public Tencent Tencent { get; set; }
        public Yandex Yandex { get; set; }
        public Ikarus Ikarus { get; set; }
        public Fortinet Fortinet { get; set; }
        public AVG AVG { get; set; }
        public Panda Panda { get; set; }

        [JsonProperty("Qihoo-360")]
        public Qihoo360 Qihoo360 { get; set; }
    }

    public class Rising
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class Root
    {
        public Meta meta { get; set; }
        public Data data { get; set; }
    }

    public class Sophos
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class Stats
    {
        public int harmless { get; set; }
         
        [JsonProperty("type-unsupported")]
        public int typeunsupported { get; set; }
        public int suspicious { get; set; }

        [JsonProperty("confirmed-timeout")]
        public int confirmedtimeout { get; set; }
        public int timeout { get; set; }
        public int failure { get; set; }
        public int malicious { get; set; }
        public int undetected { get; set; }
    }

    public class SUPERAntiSpyware
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class Symantec
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class Tencent
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class TheHacker
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class TrendMicro
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class TrendMicroHouseCall
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class VBA32
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class VIPRE
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class ViRobot
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class Yandex
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class Zillya
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }

    public class Zoner
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }


}
