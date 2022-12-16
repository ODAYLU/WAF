using Newtonsoft.Json;

namespace WAF.Models
{
    public class ModelDTO
    {
        public string? url { get; set; }
        public IFormFile? file { get; set; }
    }
    public class DataDTO
    {
        public string type { get; set; }
        public string id { get; set; }
    }
    public class RootData
    {
        public DataDTO data { get; set; }
    }
    public class RootError
    {
        public ErrorDTO error { get; set; }
    }
    public class ErrorDTO
    {
        public string message { get; set; }
        public string code { get; set; }
    }
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class _0xSIF33d
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class Abusix
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class Acronis
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class ADMINUSLabs
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class AICCMONITORAPP
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class AlienVault
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class AlphaMountainAi
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class AntiyAVL
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class ArtistsAgainst419
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class AutoShun
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class Avira
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class BADWAREINFO
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class BenkowCc
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class BforeAiPreCrime
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class BitDefender
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class Bkav
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class BlockList
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class Blueliv
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class Certego
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class ChongLuaDao
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class CINSArmy
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class CMCThreatIntelligence
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class ComodoValkyrieVerdict
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class CRDF
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class Cyan
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class CyberCrime
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class Cyble
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class CyRadar
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class DesenmascaraMe
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class DNS8
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class DrWeb
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class EmergingThreats
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class Emsisoft
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class ESET
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class ESTsecurity
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class FeodoTracker
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class ForcepointThreatSeeker
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class Fortinet
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class GData
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class GoogleSafebrowsing
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class GreenSnow
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class HeimdalSecurity
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class HopliteIndustries
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class IPsum
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class JuniperNetworks
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class K7AntiVirus
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class Kaspersky
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class Lionic
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class Lumu
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class MalBeacon
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class MalSilo
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class Malwared
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class MalwarePatrol
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class MalwaresComURLChecker
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class Netcraft
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class Nucleon
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class OpenPhish
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class PhishFort
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class PhishingDatabase
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class PhishLabs
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class Phishtank
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class PREBYTES
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class PrecisionSec
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class QuickHeal
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class Quttera
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class Rising
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class Root
    {
        public string scan_id { get; set; }
        public string resource { get; set; }
        public string url { get; set; }
        public int response_code { get; set; }
        public string scan_date { get; set; }
        public string permalink { get; set; }
        public string verbose_msg { get; set; }
        public object filescan_id { get; set; }
        public int positives { get; set; }
        public int total { get; set; }
        public Scans scans { get; set; }
    }

    public class SafeToOpen
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class Sangfor
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class Scans
    {
        public Bkav Bkav { get; set; }

        [JsonProperty("CMC Threat Intelligence")]
        public CMCThreatIntelligence CMCThreatIntelligence { get; set; }

        [JsonProperty("Snort IP sample list")]
        public SnortIPSampleList SnortIPsamplelist { get; set; }

        [JsonProperty("0xSI_f33d")]
        public _0xSIF33d _0xSI_f33d { get; set; }
        public ViriBack ViriBack { get; set; }

        [JsonProperty("Comodo Valkyrie Verdict")]
        public ComodoValkyrieVerdict ComodoValkyrieVerdict { get; set; }
        public PhishLabs PhishLabs { get; set; }
        public K7AntiVirus K7AntiVirus { get; set; }

        [JsonProperty("CINS Army")]
        public CINSArmy CINSArmy { get; set; }
        public Quttera Quttera { get; set; }
        public BlockList BlockList { get; set; }
        public PrecisionSec PrecisionSec { get; set; }
        public OpenPhish OpenPhish { get; set; }

        [JsonProperty("VX Vault")]
        public VXVault VXVault { get; set; }

        [JsonProperty("Feodo Tracker")]
        public FeodoTracker FeodoTracker { get; set; }

        [JsonProperty("Web Security Guard")]
        public WebSecurityGuard WebSecurityGuard { get; set; }
        public Scantitan Scantitan { get; set; }
        public AlienVault AlienVault { get; set; }
        public Sophos Sophos { get; set; }
        public Phishtank Phishtank { get; set; }
        public CyberCrime CyberCrime { get; set; }
        public Spam404 Spam404 { get; set; }
        public SecureBrain SecureBrain { get; set; }

        [JsonProperty("Hoplite Industries")]
        public HopliteIndustries HopliteIndustries { get; set; }
        public CRDF CRDF { get; set; }
        public Rising Rising { get; set; }
        public Fortinet Fortinet { get; set; }

        [JsonProperty("alphaMountain.ai")]
        public AlphaMountainAi alphaMountainai { get; set; }
        public Lionic Lionic { get; set; }
        public Cyble Cyble { get; set; }
        public Seclookup Seclookup { get; set; }

        [JsonProperty("Virusdie External Site Scan")]
        public VirusdieExternalSiteScan VirusdieExternalSiteScan { get; set; }

        [JsonProperty("Artists Against 419")]
        public ArtistsAgainst419 ArtistsAgainst419 { get; set; }

        [JsonProperty("Google Safebrowsing")]
        public GoogleSafebrowsing GoogleSafebrowsing { get; set; }
        public SafeToOpen SafeToOpen { get; set; }
        public ADMINUSLabs ADMINUSLabs { get; set; }
        public ESTsecurity ESTsecurity { get; set; }

        [JsonProperty("Juniper Networks")]
        public JuniperNetworks JuniperNetworks { get; set; }

        [JsonProperty("Heimdal Security")]
        public HeimdalSecurity HeimdalSecurity { get; set; }
        public AutoShun AutoShun { get; set; }
        public Trustwave Trustwave { get; set; }

        [JsonProperty("AICC (MONITORAPP)")]
        public AICCMONITORAPP AICCMONITORAPP { get; set; }
        public CyRadar CyRadar { get; set; }

        [JsonProperty("Dr.Web")]
        public DrWeb DrWeb { get; set; }
        public Emsisoft Emsisoft { get; set; }
        public Abusix Abusix { get; set; }
        public Webroot Webroot { get; set; }
        public Avira Avira { get; set; }
        public Securolytics securolytics { get; set; }

        [JsonProperty("Antiy-AVL")]
        public AntiyAVL AntiyAVL { get; set; }
        public Acronis Acronis { get; set; }

        [JsonProperty("Quick Heal")]
        public QuickHeal QuickHeal { get; set; }
        public URLQuery URLQuery { get; set; }

        [JsonProperty("Viettel Threat Intelligence")]
        public ViettelThreatIntelligence ViettelThreatIntelligence { get; set; }
        public DNS8 DNS8 { get; set; }

        [JsonProperty("benkow.cc")]
        public BenkowCc benkowcc { get; set; }
        public EmergingThreats EmergingThreats { get; set; }

        [JsonProperty("Chong Lua Dao")]
        public ChongLuaDao ChongLuaDao { get; set; }

        [JsonProperty("Yandex Safebrowsing")]
        public YandexSafebrowsing YandexSafebrowsing { get; set; }
        public Lumu Lumu { get; set; }
        public Kaspersky Kaspersky { get; set; }

        [JsonProperty("Sucuri SiteCheck")]
        public SucuriSiteCheck SucuriSiteCheck { get; set; }

        [JsonProperty("desenmascara.me")]
        public DesenmascaraMe desenmascarame { get; set; }
        public URLhaus URLhaus { get; set; }
        public PREBYTES PREBYTES { get; set; }
        public StopForumSpam StopForumSpam { get; set; }
        public Blueliv Blueliv { get; set; }
        public Netcraft Netcraft { get; set; }
        public ZeroCERT ZeroCERT { get; set; }

        [JsonProperty("Phishing Database")]
        public PhishingDatabase PhishingDatabase { get; set; }
        public MalwarePatrol MalwarePatrol { get; set; }
        public MalBeacon MalBeacon { get; set; }
        public Sangfor Sangfor { get; set; }
        public IPsum IPsum { get; set; }
        public Malwared Malwared { get; set; }
        public BitDefender BitDefender { get; set; }
        public GreenSnow GreenSnow { get; set; }

        [JsonProperty("G-Data")]
        public GData GData { get; set; }
        public Cyan Cyan { get; set; }
        public VIPRE VIPRE { get; set; }

        [JsonProperty("SCUMWARE.org")]
        public SCUMWAREOrg SCUMWAREorg { get; set; }
        public PhishFort PhishFort { get; set; }

        [JsonProperty("malwares.com URL checker")]
        public MalwaresComURLChecker malwarescomURLchecker { get; set; }

        [JsonProperty("Forcepoint ThreatSeeker")]
        public ForcepointThreatSeeker ForcepointThreatSeeker { get; set; }
        public Certego Certego { get; set; }
        public ESET ESET { get; set; }
        public Threatsourcing Threatsourcing { get; set; }
        public MalSilo MalSilo { get; set; }
        public Nucleon Nucleon { get; set; }

        [JsonProperty("BADWARE.INFO")]
        public BADWAREINFO BADWAREINFO { get; set; }
        public ThreatHive ThreatHive { get; set; }

        [JsonProperty("Bfore.Ai PreCrime")]
        public BforeAiPreCrime BforeAiPreCrime { get; set; }
    }

    public class Scantitan
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class SCUMWAREOrg
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class Seclookup
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class SecureBrain
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class Securolytics
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class SnortIPSampleList
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class Sophos
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class Spam404
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class StopForumSpam
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class SucuriSiteCheck
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class ThreatHive
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class Threatsourcing
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class Trustwave
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class URLhaus
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class URLQuery
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class ViettelThreatIntelligence
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class VIPRE
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class ViriBack
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class VirusdieExternalSiteScan
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class VXVault
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class Webroot
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class WebSecurityGuard
    {
        public bool detected { get; set; }
        public string result { get; set; }
    }

    public class YandexSafebrowsing
    {
        public bool detected { get; set; }
        public string result { get; set; }
        public string detail { get; set; }
    }

    public class ZeroCERT
    {
        public bool detected { get; set; }
        public string result { get; set; }
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


    public class Arcabit
    {
        public string category { get; set; }
        public string engine_name { get; set; }
        public string engine_version { get; set; }
        public object result { get; set; }
        public string method { get; set; }
        public string engine_update { get; set; }
    }
    public class RootAttr
    {
        public Attributes attributes { get; set; }
    }

    public class Attributes
    {
        public int date { get; set; }
        public string status { get; set; }
        public Stats stats { get; set; }
        
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

  

    public class ESETNOD32
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


    public class K7GW
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

   



}
