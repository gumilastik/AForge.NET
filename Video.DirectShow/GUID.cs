using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VVVV.AForge.Video.DirectShow
{
    #pragma warning disable 1591

    public static class GUID
    {
        #region MediaSubType

        public const string MEDIASUBTYPE_None = "E436EB8E-524F-11CE-9F53-0020AF0BA770";
        public const string MEDIASUBTYPE_CLPL = "4C504C43-0000-0010-8000-00AA00389B71";
        public const string MEDIASUBTYPE_YUYV = "56595559-0000-0010-8000-00AA00389B71";
        public const string MEDIASUBTYPE_IYUV = "56555949-0000-0010-8000-00AA00389B71";
        public const string MEDIASUBTYPE_YVU9 = "39555659-0000-0010-8000-00AA00389B71";
        public const string MEDIASUBTYPE_Y411 = "31313459-0000-0010-8000-00AA00389B71";
        public const string MEDIASUBTYPE_Y41P = "50313459-0000-0010-8000-00AA00389B71";
        public const string MEDIASUBTYPE_YUY2 = "32595559-0000-0010-8000-00AA00389B71";
        public const string MEDIASUBTYPE_YVYU = "55595659-0000-0010-8000-00AA00389B71";
        public const string MEDIASUBTYPE_UYVY = "59565955-0000-0010-8000-00AA00389B71";
        public const string MEDIASUBTYPE_Y211 = "31313259-0000-0010-8000-00AA00389B71";
        public const string MEDIASUBTYPE_CLJR = "524A4C43-0000-0010-8000-00AA00389B71";
        public const string MEDIASUBTYPE_IF09 = "39304649-0000-0010-8000-00AA00389B71";
        public const string MEDIASUBTYPE_CPLA = "414C5043-0000-0010-8000-00AA00389B71";
        public const string MEDIASUBTYPE_MJPG = "47504A4D-0000-0010-8000-00AA00389B71";
        public const string MEDIASUBTYPE_TVMJ = "4A4D5654-0000-0010-8000-00AA00389B71";
        public const string MEDIASUBTYPE_WAKE = "454B4157-0000-0010-8000-00AA00389B71";
        public const string MEDIASUBTYPE_CFCC = "43434643-0000-0010-8000-00AA00389B71";
        public const string MEDIASUBTYPE_IJPG = "47504A49-0000-0010-8000-00AA00389B71";
        public const string MEDIASUBTYPE_Plum = "6D756C50-0000-0010-8000-00AA00389B71";
        public const string MEDIASUBTYPE_DVSD = "44535644-0000-0010-8000-00AA00389B71";
        public const string MEDIASUBTYPE_MDVF = "4656444D-0000-0010-8000-00AA00389B71";
        public const string MEDIASUBTYPE_RGB1 = "E436EB78-524F-11CE-9F53-0020AF0BA770";
        public const string MEDIASUBTYPE_RGB4 = "E436EB79-524F-11CE-9F53-0020AF0BA770";
        public const string MEDIASUBTYPE_RGB8 = "E436EB7A-524F-11CE-9F53-0020AF0BA770";
        public const string MEDIASUBTYPE_RGB565 = "E436EB7B-524F-11CE-9F53-0020AF0BA770";
        public const string MEDIASUBTYPE_RGB555 = "E436EB7C-524F-11CE-9F53-0020AF0BA770";
        public const string MEDIASUBTYPE_RGB24 = "E436EB7D-524F-11CE-9F53-0020AF0BA770";
        public const string MEDIASUBTYPE_RGB32 = "E436EB7E-524F-11CE-9F53-0020AF0BA770";
        public const string MEDIASUBTYPE_ARGB1555 = "297C55AF-E209-4CB3-B757-C76D6B9C88A8";
        public const string MEDIASUBTYPE_ARGB4444 = "6E6415E6-5C24-425F-93CD-80102B3D1CCA";
        public const string MEDIASUBTYPE_ARGB32 = "773C9AC0-3274-11D0-B724-00AA006C1A01";
        public const string MEDIASUBTYPE_A2R10G10B10 = "2F8BB76D-B644-4550-ACF3-D30CAA65D5C5";
        public const string MEDIASUBTYPE_A2B10G10R10 = "576F7893-BDF6-48C4-875F-AE7B81834567";
        public const string MEDIASUBTYPE_AYUV = "56555941-0000-0010-8000-00AA00389B71";
        public const string MEDIASUBTYPE_AI44 = "34344941-0000-0010-8000-00AA00389B71";
        public const string MEDIASUBTYPE_IA44 = "34344149-0000-0010-8000-00AA00389B71";
        public const string MEDIASUBTYPE_YV12 = "32315659-0000-0010-8000-00AA00389B71";
        public const string MEDIASUBTYPE_NV12 = "3231564E-0000-0010-8000-00AA00389B71";
        public const string MEDIASUBTYPE_IMC1 = "31434D49-0000-0010-8000-00AA00389B71";
        public const string MEDIASUBTYPE_IMC2 = "32434d49-0000-0010-8000-00AA00389B71";
        public const string MEDIASUBTYPE_IMC3 = "33434d49-0000-0010-8000-00AA00389B71";
        public const string MEDIASUBTYPE_IMC4 = "34434d49-0000-0010-8000-00AA00389B71";
        public const string MEDIASUBTYPE_S340 = "30343353-0000-0010-8000-00AA00389B71";
        public const string MEDIASUBTYPE_S342 = "32343353-0000-0010-8000-00AA00389B71";
        public const string MEDIASUBTYPE_I420 = "30323449-0000-0010-8000-00AA00389B71";
        public const string MEDIASUBTYPE_Overlay = "E436EB7F-524F-11CE-9F53-0020AF0BA770";
        public const string MEDIASUBTYPE_MPEGPacket = "E436EB80-524F-11CE-9F53-0020AF0BA770";
        public const string MEDIASUBTYPE_MPEG1Payload = "E436EB81-524F-11CE-9F53-0020AF0BA770";
        public const string MEDIASUBTYPE_MPEG1AudioPayload = "00000050-0000-0010-8000-00AA00389B71";
        public const string MEDIASUBTYPE_MPEG1SystemStream = "E436EB82-524F-11CE-9F53-0020AF0BA770";
        public const string MEDIASUBTYPE_MPEG1VideoCD = "E436EB85-524F-11CE-9F53-0020AF0BA770";
        public const string MEDIASUBTYPE_MPEG1Video = "E436EB86-524F-11CE-9F53-0020AF0BA770";
        public const string MEDIASUBTYPE_MPEG1Audio = "E436EB87-524F-11CE-9F53-0020AF0BA770";
        public const string MEDIASUBTYPE_Avi = "E436EB88-524F-11CE-9F53-0020AF0BA770";
        public const string MEDIASUBTYPE_Asf = "3DB80F90-9412-11D1-ADED-0000F8754B99";
        public const string MEDIASUBTYPE_QTMovie = "E436EB89-524F-11CE-9F53-0020AF0BA770";
        public const string MEDIASUBTYPE_Rpza = "617A7072-0000-0010-8000-00AA00389B71";
        public const string MEDIASUBTYPE_Smc = "20636D73-0000-0010-8000-00AA00389B71";
        public const string MEDIASUBTYPE_Rle = "20656C72-0000-0010-8000-00AA00389B71";
        public const string MEDIASUBTYPE_Jpeg = "6765706A-0000-0010-8000-00AA00389B71";
        public const string MEDIASUBTYPE_PCMAudio_Obsolete = "E436EB8A-524F-11CE-9F53-0020AF0BA770";
        public const string MEDIASUBTYPE_PCM = "00000001-0000-0010-8000-00AA00389B71";
        public const string MEDIASUBTYPE_WAVE = "E436EB8B-524F-11CE-9F53-0020AF0BA770";
        public const string MEDIASUBTYPE_AU = "E436EB8C-524F-11CE-9F53-0020AF0BA770";
        public const string MEDIASUBTYPE_AIFF = "E436EB8D-524F-11CE-9F53-0020AF0BA770";
        public const string MEDIASUBTYPE_dvsd2 = "64737664-0000-0010-8000-00AA00389B71";
        public const string MEDIASUBTYPE_dvhd = "64687664-0000-0010-8000-00AA00389B71";
        public const string MEDIASUBTYPE_dvsl = "6C737664-0000-0010-8000-00AA00389B71";
        public const string MEDIASUBTYPE_dv25 = "35327664-0000-0010-8000-00AA00389B71";
        public const string MEDIASUBTYPE_dv50 = "30357664-0000-0010-8000-00AA00389B71";
        public const string MEDIASUBTYPE_dvh1 = "31687664-0000-0010-8000-00AA00389B71";
        public const string MEDIASUBTYPE_Line21_BytePair = "6E8D4A22-310C-11D0-B79A-00AA003767A7";
        public const string MEDIASUBTYPE_Line21_GOPPacket = "6E8D4A23-310C-11D0-B79A-00AA003767A7";
        public const string MEDIASUBTYPE_Line21_VBIRawData = "6E8D4A24-310C-11D0-B79A-00AA003767A7";
        public const string MEDIASUBTYPE_TELETEXT = "F72A76E3-EB0A-11D0-ACE4-0000C0CC16BA";

        public const string MEDIASUBTYPE_v210 = "30313276-B0B0-4DD3-8E8C-572692D526F6";
        public const string MEDIASUBTYPE_v210a = "30313276-0000-0010-8000-00AA00389B71";
        public const string MEDIASUBTYPE_r210 = "30313272-0000-0010-8000-00AA00389B71";
        public const string MEDIASUBTYPE_HDYC = "43594448-0000-0010-8000-00AA00389B71";

        public const string MEDIASUBTYPE_not_standart_YV12 = "32315659-F072-40CA-829D-47D5D2835422";
        public const string MEDIASUBTYPE_unknown_QYUV = "56555951-0000-0010-8000-00AA00389B71";

        public static string GetNickname(Guid g)
        {
            string name = g.ToString().ToUpper();
            switch (name)
            {
                case GUID.MEDIASUBTYPE_None: name = "None"; break;
                case GUID.MEDIASUBTYPE_CLPL: name = "CLPL"; break;
                case GUID.MEDIASUBTYPE_YUYV: name = "YUYV"; break;
                case GUID.MEDIASUBTYPE_IYUV: name = "IYUV"; break;
                case GUID.MEDIASUBTYPE_YVU9: name = "YVU9"; break;
                case GUID.MEDIASUBTYPE_Y411: name = "Y411"; break;
                case GUID.MEDIASUBTYPE_Y41P: name = "Y41P"; break;
                case GUID.MEDIASUBTYPE_YUY2: name = "YUY2"; break;
                case GUID.MEDIASUBTYPE_YVYU: name = "YVYU"; break;
                case GUID.MEDIASUBTYPE_UYVY: name = "UYVY"; break;
                case GUID.MEDIASUBTYPE_Y211: name = "Y211"; break;
                case GUID.MEDIASUBTYPE_CLJR: name = "CLJR"; break;
                case GUID.MEDIASUBTYPE_IF09: name = "IF09"; break;
                case GUID.MEDIASUBTYPE_CPLA: name = "CPLA"; break;
                case GUID.MEDIASUBTYPE_MJPG: name = "MJPG"; break;
                case GUID.MEDIASUBTYPE_TVMJ: name = "TVMJ"; break;
                case GUID.MEDIASUBTYPE_WAKE: name = "WAKE"; break;
                case GUID.MEDIASUBTYPE_CFCC: name = "CFCC"; break;
                case GUID.MEDIASUBTYPE_IJPG: name = "IJPG"; break;
                case GUID.MEDIASUBTYPE_Plum: name = "Plum"; break;
                case GUID.MEDIASUBTYPE_DVSD: name = "DVSD"; break;
                case GUID.MEDIASUBTYPE_MDVF: name = "MDVF"; break;
                case GUID.MEDIASUBTYPE_RGB1: name = "RGB1"; break;
                case GUID.MEDIASUBTYPE_RGB4: name = "RGB4"; break;
                case GUID.MEDIASUBTYPE_RGB8: name = "RGB8"; break;
                case GUID.MEDIASUBTYPE_RGB565: name = "RGB565"; break;
                case GUID.MEDIASUBTYPE_RGB555: name = "RGB555"; break;
                case GUID.MEDIASUBTYPE_RGB24: name = "RGB24"; break;
                case GUID.MEDIASUBTYPE_RGB32: name = "RGB32"; break;
                case GUID.MEDIASUBTYPE_ARGB1555: name = "ARGB1555"; break;
                case GUID.MEDIASUBTYPE_ARGB4444: name = "ARGB4444"; break;
                case GUID.MEDIASUBTYPE_ARGB32: name = "ARGB32"; break;
                case GUID.MEDIASUBTYPE_A2R10G10B10: name = "A2R10G10B10"; break;
                case GUID.MEDIASUBTYPE_A2B10G10R10: name = "A2B10G10R10"; break;
                case GUID.MEDIASUBTYPE_AYUV: name = "AYUV"; break;
                case GUID.MEDIASUBTYPE_AI44: name = "AI44"; break;
                case GUID.MEDIASUBTYPE_IA44: name = "IA44"; break;
                case GUID.MEDIASUBTYPE_YV12: name = "YV12"; break;
                case GUID.MEDIASUBTYPE_NV12: name = "NV12"; break;
                case GUID.MEDIASUBTYPE_IMC1: name = "IMC1"; break;
                case GUID.MEDIASUBTYPE_IMC2: name = "IMC2"; break;
                case GUID.MEDIASUBTYPE_IMC3: name = "IMC3"; break;
                case GUID.MEDIASUBTYPE_IMC4: name = "IMC4"; break;
                case GUID.MEDIASUBTYPE_S340: name = "S340"; break;
                case GUID.MEDIASUBTYPE_S342: name = "S342"; break;
                case GUID.MEDIASUBTYPE_I420: name = "I420"; break;
                case GUID.MEDIASUBTYPE_Overlay: name = "Overlay"; break;
                case GUID.MEDIASUBTYPE_MPEGPacket: name = "MPEGPacket"; break;
                case GUID.MEDIASUBTYPE_MPEG1Payload: name = "MPEG1Payload"; break;
                case GUID.MEDIASUBTYPE_MPEG1AudioPayload: name = "MPEG1AudioPayload"; break;
                case GUID.MEDIASUBTYPE_MPEG1SystemStream: name = "MPEG1SystemStream"; break;
                case GUID.MEDIASUBTYPE_MPEG1VideoCD: name = "MPEG1VideoCD"; break;
                case GUID.MEDIASUBTYPE_MPEG1Video: name = "MPEG1Video"; break;
                case GUID.MEDIASUBTYPE_MPEG1Audio: name = "MPEG1Audio"; break;
                case GUID.MEDIASUBTYPE_Avi: name = "AVI"; break;
                case GUID.MEDIASUBTYPE_Asf: name = "Asf"; break;
                case GUID.MEDIASUBTYPE_QTMovie: name = "QTMovie"; break;
                case GUID.MEDIASUBTYPE_Rpza: name = "Rpza"; break;
                case GUID.MEDIASUBTYPE_Smc: name = "Smc"; break;
                case GUID.MEDIASUBTYPE_Rle: name = "Rle"; break;
                case GUID.MEDIASUBTYPE_Jpeg: name = "Jpeg"; break;
                case GUID.MEDIASUBTYPE_PCMAudio_Obsolete: name = "PCMAudio_Obsolete"; break;
                case GUID.MEDIASUBTYPE_PCM: name = "PCM"; break;
                case GUID.MEDIASUBTYPE_WAVE: name = "WAVE"; break;
                case GUID.MEDIASUBTYPE_AU: name = "AU"; break;
                case GUID.MEDIASUBTYPE_AIFF: name = "AIFF"; break;
                case GUID.MEDIASUBTYPE_dvsd2: name = "dvsd2"; break;
                case GUID.MEDIASUBTYPE_dvhd: name = "dvhd"; break;
                case GUID.MEDIASUBTYPE_dvsl: name = "dvsl"; break;
                case GUID.MEDIASUBTYPE_dv25: name = "dv25"; break;
                case GUID.MEDIASUBTYPE_dv50: name = "dv50"; break;
                case GUID.MEDIASUBTYPE_dvh1: name = "dvh1"; break;
                case GUID.MEDIASUBTYPE_Line21_BytePair: name = "Line21_BytePair"; break;
                case GUID.MEDIASUBTYPE_Line21_GOPPacket: name = "Line21_GOPPacket"; break;
                case GUID.MEDIASUBTYPE_Line21_VBIRawData: name = "Line21_VBIRawData"; break;
                case GUID.MEDIASUBTYPE_TELETEXT: name = "TELETEXT"; break;

                case GUID.MEDIASUBTYPE_v210: name = "v210"; break;
                case GUID.MEDIASUBTYPE_v210a: name = "v210a"; break;
                case GUID.MEDIASUBTYPE_r210: name = "r210"; break;
                case GUID.MEDIASUBTYPE_HDYC: name = "HDYC"; break;

                case GUID.MEDIASUBTYPE_not_standart_YV12: name = "YV12"; break;
                case GUID.MEDIASUBTYPE_unknown_QYUV: name = "QYUV"; break;
            }

            return name;
        }
        #endregion
    }

}
