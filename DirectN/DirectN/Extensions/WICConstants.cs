﻿using System;

namespace DirectN
{
    public static class WICConstants
    {
        // wincodec.h
        public static readonly Guid CATID_WICBitmapDecoders = new Guid("7ed96837-96f0-4812-b211-f13c24117ed3");
        public static readonly Guid CATID_WICBitmapEncoders = new Guid("ac757296-3522-4e11-9862-c17be5a1767e");
        public static readonly Guid CATID_WICFormatConverters = new Guid("7835eae8-bf14-49d1-93ce-533a407b2248");
        public static readonly Guid CATID_WICMetadataReader = new Guid("05af94d8-7174-4cd2-be4a-4124b80ee4b8");
        public static readonly Guid CATID_WICMetadataWriter = new Guid("abe3b9a4-257d-4b97-bd1a-294af496222e");
        public static readonly Guid CATID_WICPixelFormats = new Guid("2b46e70f-cda7-473e-89f6-dc9630a2390b");
        public static readonly Guid CLSID_WICAdngDecoder = new Guid("981d9411-909e-42a7-8f5d-a747ff052edb");
        public static readonly Guid CLSID_WICBmpDecoder = new Guid("6b462062-7cbf-400d-9fdb-813dd10f2778");
        public static readonly Guid CLSID_WICBmpEncoder = new Guid("69be8bb4-d66d-47c8-865a-ed1589433782");
        public static readonly Guid CLSID_WICDdsDecoder = new Guid("9053699f-a341-429d-9e90-ee437cf80c73");
        public static readonly Guid CLSID_WICDdsEncoder = new Guid("a61dde94-66ce-4ac1-881b-71680588895e");
        public static readonly Guid CLSID_WICDefaultFormatConverter = new Guid("1a3f11dc-b514-4b17-8c5f-2154513852f1");
        public static readonly Guid CLSID_WICFormatConverterHighColor = new Guid("ac75d454-9f37-48f8-b972-4e19bc856011");
        public static readonly Guid CLSID_WICFormatConverterNChannel = new Guid("c17cabb2-d4a3-47d7-a557-339b2efbd4f1");
        public static readonly Guid CLSID_WICFormatConverterWMPhoto = new Guid("9cb5172b-d600-46ba-ab77-77bb7e3a00d9");
        public static readonly Guid CLSID_WICGifDecoder = new Guid("381dda3c-9ce9-4834-a23e-1f98f8fc52be");
        public static readonly Guid CLSID_WICGifEncoder = new Guid("114f5598-0b22-40a0-86a1-c83ea495adbd");
        public static readonly Guid CLSID_WICHeifDecoder = new Guid("e9a4a80a-44fe-4de4-8971-7150b10a5199");
        public static readonly Guid CLSID_WICHeifEncoder = new Guid("0dbecec1-9eb3-4860-9c6f-ddbe86634575");
        public static readonly Guid CLSID_WICIcoDecoder = new Guid("c61bfcdf-2e0f-4aad-a8d7-e06bafebcdfe");
        public static readonly Guid CLSID_WICImagingCategories = new Guid("fae3d380-fea4-4623-8c75-c6b61110b681");
        public static readonly Guid CLSID_WICImagingFactory = new Guid("cacaf262-9370-4615-a13b-9f5539da4c0a");
        public static readonly Guid CLSID_WICImagingFactory1 = new Guid("cacaf262-9370-4615-a13b-9f5539da4c0a");
        public static readonly Guid CLSID_WICImagingFactory2 = new Guid("317d06e8-5f24-433d-bdf7-79ce68d8abc2");
        public static readonly Guid CLSID_WICJpegDecoder = new Guid("9456a480-e88b-43ea-9e73-0b2d9b71b1ca");
        public static readonly Guid CLSID_WICJpegEncoder = new Guid("1a34f5c1-4a5a-46dc-b644-1f4567e7a676");
        public static readonly Guid CLSID_WICJpegQualcommPhoneEncoder = new Guid("68ed5c62-f534-4979-b2b3-686a12b2b34c");
        public static readonly Guid CLSID_WICPlanarFormatConverter = new Guid("184132b8-32f8-4784-9131-dd7224b23438");
        public static readonly Guid CLSID_WICPngDecoder = new Guid("389ea17b-5078-4cde-b6ef-25c15175c751");
        public static readonly Guid CLSID_WICPngDecoder1 = new Guid("389ea17b-5078-4cde-b6ef-25c15175c751");
        public static readonly Guid CLSID_WICPngDecoder2 = new Guid("e018945b-aa86-4008-9bd4-6777a1e40c11");
        public static readonly Guid CLSID_WICPngEncoder = new Guid("27949969-876a-41d7-9447-568f6a35a4dc");
        public static readonly Guid CLSID_WICRAWDecoder = new Guid("41945702-8302-44a6-9445-ac98e8afa086");
        public static readonly Guid CLSID_WICTiffDecoder = new Guid("b54e85d9-fe23-499f-8b88-6acea713752b");
        public static readonly Guid CLSID_WICTiffEncoder = new Guid("0131be10-2001-4c5f-a9b0-cc88fab64ce8");
        public static readonly Guid CLSID_WICWebpDecoder = new Guid("7693e886-51c9-4070-8419-9f70738ec8fa");
        public static readonly Guid CLSID_WICWmpDecoder = new Guid("a26cec36-234c-4950-ae16-e34aace71d0d");
        public static readonly Guid CLSID_WICWmpEncoder = new Guid("ac4ce3cb-e1c1-44cd-8215-5a1665509ec2");
        public static readonly Guid GUID_ContainerFormatAdng = new Guid("f3ff6d0d-38c0-41c4-b1fe-1f3824f17b84");
        public static readonly Guid GUID_ContainerFormatBmp = new Guid("0af1d87e-fcfe-4188-bdeb-a7906471cbe3");
        public static readonly Guid GUID_ContainerFormatDds = new Guid("9967cb95-2e85-4ac8-8ca2-83d7ccd425c9");
        public static readonly Guid GUID_ContainerFormatGif = new Guid("1f8a5601-7d4d-4cbd-9c82-1bc8d4eeb9a5");
        public static readonly Guid GUID_ContainerFormatHeif = new Guid("e1e62521-6787-405b-a339-500715b5763f");
        public static readonly Guid GUID_ContainerFormatIco = new Guid("a3a860c4-338f-4c17-919a-fba4b5628f21");
        public static readonly Guid GUID_ContainerFormatJpeg = new Guid("19e4a5aa-5662-4fc5-a0c0-1758028e1057");
        public static readonly Guid GUID_ContainerFormatPng = new Guid("1b7cfaf4-713f-473c-bbcd-6137425faeaf");
        public static readonly Guid GUID_ContainerFormatRaw = new Guid("fe99ce60-f19c-433c-a3ae-00acefa9ca21");
        public static readonly Guid GUID_ContainerFormatTiff = new Guid("163bcc30-e2e9-4f0b-961d-a3e9fdb788a3");
        public static readonly Guid GUID_ContainerFormatWebp = new Guid("e094b0e2-67f2-45b3-b0ea-115337ca7cf3");
        public static readonly Guid GUID_ContainerFormatWmp = new Guid("57a37caa-367a-4540-916b-f183c5093a4b");
        public static readonly Guid GUID_VendorMicrosoft = new Guid("f0e749ca-edef-4589-a73a-ee0e626a2a2b");
        public static readonly Guid GUID_VendorMicrosoftBuiltIn = new Guid("257a30fd-06b6-462b-aea4-63f70b86e533");
        public static readonly Guid GUID_WICPixelFormat112bpp6ChannelsAlpha = new Guid("6fddc324-4e03-4bfe-b185-3d77768dc937");
        public static readonly Guid GUID_WICPixelFormat112bpp7Channels = new Guid("6fddc324-4e03-4bfe-b185-3d77768dc92a");
        public static readonly Guid GUID_WICPixelFormat128bpp7ChannelsAlpha = new Guid("6fddc324-4e03-4bfe-b185-3d77768dc938");
        public static readonly Guid GUID_WICPixelFormat128bpp8Channels = new Guid("6fddc324-4e03-4bfe-b185-3d77768dc92b");
        public static readonly Guid GUID_WICPixelFormat128bppPRGBAFloat = new Guid("6fddc324-4e03-4bfe-b185-3d77768dc91a");
        public static readonly Guid GUID_WICPixelFormat128bppRGBAFixedPoint = new Guid("6fddc324-4e03-4bfe-b185-3d77768dc91e");
        public static readonly Guid GUID_WICPixelFormat128bppRGBAFloat = new Guid("6fddc324-4e03-4bfe-b185-3d77768dc919");
        public static readonly Guid GUID_WICPixelFormat128bppRGBFixedPoint = new Guid("6fddc324-4e03-4bfe-b185-3d77768dc941");
        public static readonly Guid GUID_WICPixelFormat128bppRGBFloat = new Guid("6fddc324-4e03-4bfe-b185-3d77768dc91b");
        public static readonly Guid GUID_WICPixelFormat144bpp8ChannelsAlpha = new Guid("6fddc324-4e03-4bfe-b185-3d77768dc939");
        public static readonly Guid GUID_WICPixelFormat16bppBGR555 = new Guid("6fddc324-4e03-4bfe-b185-3d77768dc909");
        public static readonly Guid GUID_WICPixelFormat16bppBGR565 = new Guid("6fddc324-4e03-4bfe-b185-3d77768dc90a");
        public static readonly Guid GUID_WICPixelFormat16bppBGRA5551 = new Guid("05ec7c2b-f1e6-4961-ad46-e1cc810a87d2");
        public static readonly Guid GUID_WICPixelFormat16bppCbCr = new Guid("ff95ba6e-11e0-4263-bb45-01721f3460a4");
        public static readonly Guid GUID_WICPixelFormat16bppCbQuantizedDctCoefficients = new Guid("d2c4ff61-56a5-49c2-8b5c-4c1925964837");
        public static readonly Guid GUID_WICPixelFormat16bppCrQuantizedDctCoefficients = new Guid("2fe354f0-1680-42d8-9231-e73c0565bfc1");
        public static readonly Guid GUID_WICPixelFormat16bppGray = new Guid("6fddc324-4e03-4bfe-b185-3d77768dc90b");
        public static readonly Guid GUID_WICPixelFormat16bppGrayFixedPoint = new Guid("6fddc324-4e03-4bfe-b185-3d77768dc913");
        public static readonly Guid GUID_WICPixelFormat16bppGrayHalf = new Guid("6fddc324-4e03-4bfe-b185-3d77768dc93e");
        public static readonly Guid GUID_WICPixelFormat16bppYQuantizedDctCoefficients = new Guid("a355f433-48e8-4a42-84d8-e2aa26ca80a4");
        public static readonly Guid GUID_WICPixelFormat1bppIndexed = new Guid("6fddc324-4e03-4bfe-b185-3d77768dc901");
        public static readonly Guid GUID_WICPixelFormat24bpp3Channels = new Guid("6fddc324-4e03-4bfe-b185-3d77768dc920");
        public static readonly Guid GUID_WICPixelFormat24bppBGR = new Guid("6fddc324-4e03-4bfe-b185-3d77768dc90c");
        public static readonly Guid GUID_WICPixelFormat24bppRGB = new Guid("6fddc324-4e03-4bfe-b185-3d77768dc90d");
        public static readonly Guid GUID_WICPixelFormat2bppGray = new Guid("6fddc324-4e03-4bfe-b185-3d77768dc906");
        public static readonly Guid GUID_WICPixelFormat2bppIndexed = new Guid("6fddc324-4e03-4bfe-b185-3d77768dc902");
        public static readonly Guid GUID_WICPixelFormat32bpp3ChannelsAlpha = new Guid("6fddc324-4e03-4bfe-b185-3d77768dc92e");
        public static readonly Guid GUID_WICPixelFormat32bpp4Channels = new Guid("6fddc324-4e03-4bfe-b185-3d77768dc921");
        public static readonly Guid GUID_WICPixelFormat32bppBGR = new Guid("6fddc324-4e03-4bfe-b185-3d77768dc90e");
        public static readonly Guid GUID_WICPixelFormat32bppBGR101010 = new Guid("6fddc324-4e03-4bfe-b185-3d77768dc914");
        public static readonly Guid GUID_WICPixelFormat32bppBGRA = new Guid("6fddc324-4e03-4bfe-b185-3d77768dc90f");
        public static readonly Guid GUID_WICPixelFormat32bppCMYK = new Guid("6fddc324-4e03-4bfe-b185-3d77768dc91c");
        public static readonly Guid GUID_WICPixelFormat32bppGrayFixedPoint = new Guid("6fddc324-4e03-4bfe-b185-3d77768dc93f");
        public static readonly Guid GUID_WICPixelFormat32bppGrayFloat = new Guid("6fddc324-4e03-4bfe-b185-3d77768dc911");
        public static readonly Guid GUID_WICPixelFormat32bppPBGRA = new Guid("6fddc324-4e03-4bfe-b185-3d77768dc910");
        public static readonly Guid GUID_WICPixelFormat32bppPRGBA = new Guid("3cc4a650-a527-4d37-a916-3142c7ebedba");
        public static readonly Guid GUID_WICPixelFormat32bppR10G10B10A2 = new Guid("604e1bb5-8a3c-4b65-b11c-bc0b8dd75b7f");
        public static readonly Guid GUID_WICPixelFormat32bppR10G10B10A2HDR10 = new Guid("9c215c5d-1acc-4f0e-a4bc-70fb3ae8fd28");
        public static readonly Guid GUID_WICPixelFormat32bppRGB = new Guid("d98c6b95-3efe-47d6-bb25-eb1748ab0cf1");
        public static readonly Guid GUID_WICPixelFormat32bppRGBA = new Guid("f5c7ad2d-6a8d-43dd-a7a8-a29935261ae9");
        public static readonly Guid GUID_WICPixelFormat32bppRGBA1010102 = new Guid("25238d72-fcf9-4522-b514-5578e5ad55e0");
        public static readonly Guid GUID_WICPixelFormat32bppRGBA1010102XR = new Guid("00de6b9a-c101-434b-b502-d0165ee1122c");
        public static readonly Guid GUID_WICPixelFormat32bppRGBE = new Guid("6fddc324-4e03-4bfe-b185-3d77768dc93d");
        public static readonly Guid GUID_WICPixelFormat40bpp4ChannelsAlpha = new Guid("6fddc324-4e03-4bfe-b185-3d77768dc92f");
        public static readonly Guid GUID_WICPixelFormat40bpp5Channels = new Guid("6fddc324-4e03-4bfe-b185-3d77768dc922");
        public static readonly Guid GUID_WICPixelFormat40bppCMYKAlpha = new Guid("6fddc324-4e03-4bfe-b185-3d77768dc92c");
        public static readonly Guid GUID_WICPixelFormat48bpp3Channels = new Guid("6fddc324-4e03-4bfe-b185-3d77768dc926");
        public static readonly Guid GUID_WICPixelFormat48bpp5ChannelsAlpha = new Guid("6fddc324-4e03-4bfe-b185-3d77768dc930");
        public static readonly Guid GUID_WICPixelFormat48bpp6Channels = new Guid("6fddc324-4e03-4bfe-b185-3d77768dc923");
        public static readonly Guid GUID_WICPixelFormat48bppBGR = new Guid("e605a384-b468-46ce-bb2e-36f180e64313");
        public static readonly Guid GUID_WICPixelFormat48bppBGRFixedPoint = new Guid("49ca140e-cab6-493b-9ddf-60187c37532a");
        public static readonly Guid GUID_WICPixelFormat48bppRGB = new Guid("6fddc324-4e03-4bfe-b185-3d77768dc915");
        public static readonly Guid GUID_WICPixelFormat48bppRGBFixedPoint = new Guid("6fddc324-4e03-4bfe-b185-3d77768dc912");
        public static readonly Guid GUID_WICPixelFormat48bppRGBHalf = new Guid("6fddc324-4e03-4bfe-b185-3d77768dc93b");
        public static readonly Guid GUID_WICPixelFormat4bppGray = new Guid("6fddc324-4e03-4bfe-b185-3d77768dc907");
        public static readonly Guid GUID_WICPixelFormat4bppIndexed = new Guid("6fddc324-4e03-4bfe-b185-3d77768dc903");
        public static readonly Guid GUID_WICPixelFormat56bpp6ChannelsAlpha = new Guid("6fddc324-4e03-4bfe-b185-3d77768dc931");
        public static readonly Guid GUID_WICPixelFormat56bpp7Channels = new Guid("6fddc324-4e03-4bfe-b185-3d77768dc924");
        public static readonly Guid GUID_WICPixelFormat64bpp3ChannelsAlpha = new Guid("6fddc324-4e03-4bfe-b185-3d77768dc934");
        public static readonly Guid GUID_WICPixelFormat64bpp4Channels = new Guid("6fddc324-4e03-4bfe-b185-3d77768dc927");
        public static readonly Guid GUID_WICPixelFormat64bpp7ChannelsAlpha = new Guid("6fddc324-4e03-4bfe-b185-3d77768dc932");
        public static readonly Guid GUID_WICPixelFormat64bpp8Channels = new Guid("6fddc324-4e03-4bfe-b185-3d77768dc925");
        public static readonly Guid GUID_WICPixelFormat64bppBGRA = new Guid("1562ff7c-d352-46f9-979e-42976b792246");
        public static readonly Guid GUID_WICPixelFormat64bppBGRAFixedPoint = new Guid("356de33c-54d2-4a23-bb04-9b7bf9b1d42d");
        public static readonly Guid GUID_WICPixelFormat64bppCMYK = new Guid("6fddc324-4e03-4bfe-b185-3d77768dc91f");
        public static readonly Guid GUID_WICPixelFormat64bppPBGRA = new Guid("8c518e8e-a4ec-468b-ae70-c9a35a9c5530");
        public static readonly Guid GUID_WICPixelFormat64bppPRGBA = new Guid("6fddc324-4e03-4bfe-b185-3d77768dc917");
        public static readonly Guid GUID_WICPixelFormat64bppPRGBAHalf = new Guid("58ad26c2-c623-4d9d-b320-387e49f8c442");
        public static readonly Guid GUID_WICPixelFormat64bppRGB = new Guid("a1182111-186d-4d42-bc6a-9c8303a8dff9");
        public static readonly Guid GUID_WICPixelFormat64bppRGBA = new Guid("6fddc324-4e03-4bfe-b185-3d77768dc916");
        public static readonly Guid GUID_WICPixelFormat64bppRGBAFixedPoint = new Guid("6fddc324-4e03-4bfe-b185-3d77768dc91d");
        public static readonly Guid GUID_WICPixelFormat64bppRGBAHalf = new Guid("6fddc324-4e03-4bfe-b185-3d77768dc93a");
        public static readonly Guid GUID_WICPixelFormat64bppRGBFixedPoint = new Guid("6fddc324-4e03-4bfe-b185-3d77768dc940");
        public static readonly Guid GUID_WICPixelFormat64bppRGBHalf = new Guid("6fddc324-4e03-4bfe-b185-3d77768dc942");
        public static readonly Guid GUID_WICPixelFormat72bpp8ChannelsAlpha = new Guid("6fddc324-4e03-4bfe-b185-3d77768dc933");
        public static readonly Guid GUID_WICPixelFormat80bpp4ChannelsAlpha = new Guid("6fddc324-4e03-4bfe-b185-3d77768dc935");
        public static readonly Guid GUID_WICPixelFormat80bpp5Channels = new Guid("6fddc324-4e03-4bfe-b185-3d77768dc928");
        public static readonly Guid GUID_WICPixelFormat80bppCMYKAlpha = new Guid("6fddc324-4e03-4bfe-b185-3d77768dc92d");
        public static readonly Guid GUID_WICPixelFormat8bppAlpha = new Guid("e6cd0116-eeba-4161-aa85-27dd9fb3a895");
        public static readonly Guid GUID_WICPixelFormat8bppCb = new Guid("1339f224-6bfe-4c3e-9302-e4f3a6d0ca2a");
        public static readonly Guid GUID_WICPixelFormat8bppCr = new Guid("b8145053-2116-49f0-8835-ed844b205c51");
        public static readonly Guid GUID_WICPixelFormat8bppGray = new Guid("6fddc324-4e03-4bfe-b185-3d77768dc908");
        public static readonly Guid GUID_WICPixelFormat8bppIndexed = new Guid("6fddc324-4e03-4bfe-b185-3d77768dc904");
        public static readonly Guid GUID_WICPixelFormat8bppY = new Guid("91b4db54-2df9-42f0-b449-2909bb3df88e");
        public static readonly Guid GUID_WICPixelFormat96bpp5ChannelsAlpha = new Guid("6fddc324-4e03-4bfe-b185-3d77768dc936");
        public static readonly Guid GUID_WICPixelFormat96bpp6Channels = new Guid("6fddc324-4e03-4bfe-b185-3d77768dc929");
        public static readonly Guid GUID_WICPixelFormat96bppRGBFixedPoint = new Guid("6fddc324-4e03-4bfe-b185-3d77768dc918");
        public static readonly Guid GUID_WICPixelFormat96bppRGBFloat = new Guid("e3fed78f-e8db-4acf-84c1-e97f6136b327");
        public static readonly Guid GUID_WICPixelFormatBlackWhite = new Guid("6fddc324-4e03-4bfe-b185-3d77768dc905");
        public static readonly Guid GUID_WICPixelFormatDontCare = new Guid("6fddc324-4e03-4bfe-b185-3d77768dc900");
        public static readonly Guid GUID_WICPixelFormatUndefined = new Guid("6fddc324-4e03-4bfe-b185-3d77768dc900");

        // wincodecsdk.h
        public static readonly Guid CLSID_WIC8BIMIPTCDigestMetadataReader = new Guid("02805f1e-d5aa-415b-82c5-61c033a988a6");
        public static readonly Guid CLSID_WIC8BIMIPTCDigestMetadataWriter = new Guid("2db5e62b-0d67-495f-8f9d-c2f0188647ac");
        public static readonly Guid CLSID_WIC8BIMIPTCMetadataReader = new Guid("0010668c-0801-4da6-a4a4-826522b6d28f");
        public static readonly Guid CLSID_WIC8BIMIPTCMetadataWriter = new Guid("00108226-ee41-44a2-9e9c-4be4d5b1d2cd");
        public static readonly Guid CLSID_WIC8BIMResolutionInfoMetadataReader = new Guid("5805137a-e348-4f7c-b3cc-6db9965a0599");
        public static readonly Guid CLSID_WIC8BIMResolutionInfoMetadataWriter = new Guid("4ff2fe0e-e74a-4b71-98c4-ab7dc16707ba");
        public static readonly Guid CLSID_WICAPEMetadataReader = new Guid("1767b93a-b021-44ea-920f-863c11f4f768");
        public static readonly Guid CLSID_WICAPEMetadataWriter = new Guid("bd6edfca-2890-482f-b233-8d7339a1cf8d");
        public static readonly Guid CLSID_WICApp0MetadataReader = new Guid("43324b33-a78f-480f-9111-9638aaccc832");
        public static readonly Guid CLSID_WICApp0MetadataWriter = new Guid("f3c633a2-46c8-498e-8fbb-cc6f721bbcde");
        public static readonly Guid CLSID_WICApp13MetadataReader = new Guid("aa7e3c50-864c-4604-bc04-8b0b76e637f6");
        public static readonly Guid CLSID_WICApp13MetadataWriter = new Guid("7b19a919-a9d6-49e5-bd45-02c34e4e4cd5");
        public static readonly Guid CLSID_WICApp1MetadataReader = new Guid("dde33513-774e-4bcd-ae79-02f4adfe62fc");
        public static readonly Guid CLSID_WICApp1MetadataWriter = new Guid("ee366069-1832-420f-b381-0479ad066f19");
        public static readonly Guid CLSID_WICDdsMetadataReader = new Guid("276c88ca-7533-4a86-b676-66b36080d484");
        public static readonly Guid CLSID_WICDdsMetadataWriter = new Guid("fd688bbd-31ed-4db7-a723-934927d38367");
        public static readonly Guid CLSID_WICExifMetadataReader = new Guid("d9403860-297f-4a49-bf9b-77898150a442");
        public static readonly Guid CLSID_WICExifMetadataWriter = new Guid("c9a14cda-c339-460b-9078-d4debcfabe91");
        public static readonly Guid CLSID_WICGCEMetadataReader = new Guid("b92e345d-f52d-41f3-b562-081bc772e3b9");
        public static readonly Guid CLSID_WICGCEMetadataWriter = new Guid("af95dc76-16b2-47f4-b3ea-3c31796693e7");
        public static readonly Guid CLSID_WICGifCommentMetadataReader = new Guid("32557d3b-69dc-4f95-836e-f5972b2f6159");
        public static readonly Guid CLSID_WICGifCommentMetadataWriter = new Guid("a02797fc-c4ae-418c-af95-e637c7ead2a1");
        public static readonly Guid CLSID_WICGpsMetadataReader = new Guid("3697790b-223b-484e-9925-c4869218f17a");
        public static readonly Guid CLSID_WICGpsMetadataWriter = new Guid("cb8c13e4-62b5-4c96-a48b-6ba6ace39c76");
        public static readonly Guid CLSID_WICHeifHDRMetadataReader = new Guid("2438de3d-94d9-4be8-84a8-4de95a575e75");
        public static readonly Guid CLSID_WICHeifMetadataReader = new Guid("acddfc3f-85ec-41bc-bdef-1bc262e4db05");
        public static readonly Guid CLSID_WICHeifMetadataWriter = new Guid("3ae45e79-40bc-4401-ace5-dd3cb16e6afe");
        public static readonly Guid CLSID_WICIfdMetadataReader = new Guid("8f914656-9d0a-4eb2-9019-0bf96d8a9ee6");
        public static readonly Guid CLSID_WICIfdMetadataWriter = new Guid("b1ebfc28-c9bd-47a2-8d33-b948769777a7");
        public static readonly Guid CLSID_WICIMDMetadataReader = new Guid("7447a267-0015-42c8-a8f1-fb3b94c68361");
        public static readonly Guid CLSID_WICIMDMetadataWriter = new Guid("8c89071f-452e-4e95-9682-9d1024627172");
        public static readonly Guid CLSID_WICInteropMetadataReader = new Guid("b5c8b898-0074-459f-b700-860d4651ea14");
        public static readonly Guid CLSID_WICInteropMetadataWriter = new Guid("122ec645-cd7e-44d8-b186-2c8c20c3b50f");
        public static readonly Guid CLSID_WICIPTCMetadataReader = new Guid("03012959-f4f6-44d7-9d09-daa087a9db57");
        public static readonly Guid CLSID_WICIPTCMetadataWriter = new Guid("1249b20c-5dd0-44fe-b0b3-8f92c8e6d080");
        public static readonly Guid CLSID_WICIRBMetadataReader = new Guid("d4dcd3d7-b4c2-47d9-a6bf-b89ba396a4a3");
        public static readonly Guid CLSID_WICIRBMetadataWriter = new Guid("5c5c1935-0235-4434-80bc-251bc1ec39c6");
        public static readonly Guid CLSID_WICJpegChrominanceMetadataReader = new Guid("50b1904b-f28f-4574-93f4-0bade82c69e9");
        public static readonly Guid CLSID_WICJpegChrominanceMetadataWriter = new Guid("3ff566f0-6e6b-49d4-96e6-b78886692c62");
        public static readonly Guid CLSID_WICJpegCommentMetadataReader = new Guid("9f66347c-60c4-4c4d-ab58-d2358685f607");
        public static readonly Guid CLSID_WICJpegCommentMetadataWriter = new Guid("e573236f-55b1-4eda-81ea-9f65db0290d3");
        public static readonly Guid CLSID_WICJpegLuminanceMetadataReader = new Guid("356f2f88-05a6-4728-b9a4-1bfbce04d838");
        public static readonly Guid CLSID_WICJpegLuminanceMetadataWriter = new Guid("1d583abc-8a0e-4657-9982-a380ca58fb4b");
        public static readonly Guid CLSID_WICLSDMetadataReader = new Guid("41070793-59e4-479a-a1f7-954adc2ef5fc");
        public static readonly Guid CLSID_WICLSDMetadataWriter = new Guid("73c037e7-e5d9-4954-876a-6da81d6e5768");
        public static readonly Guid CLSID_WICPngBkgdMetadataReader = new Guid("0ce7a4a6-03e8-4a60-9d15-282ef32ee7da");
        public static readonly Guid CLSID_WICPngBkgdMetadataWriter = new Guid("68e3f2fd-31ae-4441-bb6a-fd7047525f90");
        public static readonly Guid CLSID_WICPngChrmMetadataReader = new Guid("f90b5f36-367b-402a-9dd1-bc0fd59d8f62");
        public static readonly Guid CLSID_WICPngChrmMetadataWriter = new Guid("e23ce3eb-5608-4e83-bcef-27b1987e51d7");
        public static readonly Guid CLSID_WICPngGamaMetadataReader = new Guid("3692ca39-e082-4350-9e1f-3704cb083cd5");
        public static readonly Guid CLSID_WICPngGamaMetadataWriter = new Guid("ff036d13-5d4b-46dd-b10f-106693d9fe4f");
        public static readonly Guid CLSID_WICPngHistMetadataReader = new Guid("877a0bb7-a313-4491-87b5-2e6d0594f520");
        public static readonly Guid CLSID_WICPngHistMetadataWriter = new Guid("8a03e749-672e-446e-bf1f-2c11d233b6ff");
        public static readonly Guid CLSID_WICPngIccpMetadataReader = new Guid("f5d3e63b-cb0f-4628-a478-6d8244be36b1");
        public static readonly Guid CLSID_WICPngIccpMetadataWriter = new Guid("16671e5f-0ce6-4cc4-9768-e89fe5018ade");
        public static readonly Guid CLSID_WICPngItxtMetadataReader = new Guid("aabfb2fa-3e1e-4a8f-8977-5556fb94ea23");
        public static readonly Guid CLSID_WICPngItxtMetadataWriter = new Guid("31879719-e751-4df8-981d-68dff67704ed");
        public static readonly Guid CLSID_WICPngSrgbMetadataReader = new Guid("fb40360c-547e-4956-a3b9-d4418859ba66");
        public static readonly Guid CLSID_WICPngSrgbMetadataWriter = new Guid("a6ee35c6-87ec-47df-9f22-1d5aad840c82");
        public static readonly Guid CLSID_WICPngTextMetadataReader = new Guid("4b59afcc-b8c3-408a-b670-89e5fab6fda7");
        public static readonly Guid CLSID_WICPngTextMetadataWriter = new Guid("b5ebafb9-253e-4a72-a744-0762d2685683");
        public static readonly Guid CLSID_WICPngTimeMetadataReader = new Guid("d94edf02-efe5-4f0d-85c8-f5a68b3000b1");
        public static readonly Guid CLSID_WICPngTimeMetadataWriter = new Guid("1ab78400-b5a3-4d91-8ace-33fcd1499be6");
        public static readonly Guid CLSID_WICSubIfdMetadataReader = new Guid("50d42f09-ecd1-4b41-b65d-da1fdaa75663");
        public static readonly Guid CLSID_WICSubIfdMetadataWriter = new Guid("8ade5386-8e9b-4f4c-acf2-f0008706b238");
        public static readonly Guid CLSID_WICThumbnailMetadataReader = new Guid("fb012959-f4f6-44d7-9d09-daa087a9db57");
        public static readonly Guid CLSID_WICThumbnailMetadataWriter = new Guid("d049b20c-5dd0-44fe-b0b3-8f92c8e6d080");
        public static readonly Guid CLSID_WICUnknownMetadataReader = new Guid("699745c2-5066-4b82-a8e3-d40478dbec8c");
        public static readonly Guid CLSID_WICUnknownMetadataWriter = new Guid("a09cca86-27ba-4f39-9053-121fa4dc08fc");
        public static readonly Guid CLSID_WICWebpAnimMetadataReader = new Guid("076f9911-a348-465c-a807-a252f3f2d3de");
        public static readonly Guid CLSID_WICWebpAnmfMetadataReader = new Guid("85a10b03-c9f6-439f-be5e-c0fbef67807c");
        public static readonly Guid CLSID_WICXMPAltMetadataReader = new Guid("aa94dcc2-b8b0-4898-b835-000aabd74393");
        public static readonly Guid CLSID_WICXMPAltMetadataWriter = new Guid("076c2a6c-f78f-4c46-a723-3583e70876ea");
        public static readonly Guid CLSID_WICXMPBagMetadataReader = new Guid("e7e79a30-4f2c-4fab-8d00-394f2d6bbebe");
        public static readonly Guid CLSID_WICXMPBagMetadataWriter = new Guid("ed822c8c-d6be-4301-a631-0e1416bad28f");
        public static readonly Guid CLSID_WICXMPMetadataReader = new Guid("72b624df-ae11-4948-a65c-351eb0829419");
        public static readonly Guid CLSID_WICXMPMetadataWriter = new Guid("1765e14e-1bd4-462e-b6b1-590bf1262ac6");
        public static readonly Guid CLSID_WICXMPSeqMetadataReader = new Guid("7f12e753-fc71-43d7-a51d-92f35977abb5");
        public static readonly Guid CLSID_WICXMPSeqMetadataWriter = new Guid("6d68d1de-d432-4b0f-923a-091183a9bda7");
        public static readonly Guid CLSID_WICXMPStructMetadataReader = new Guid("01b90d9a-8209-47f7-9c52-e1244bf50ced");
        public static readonly Guid CLSID_WICXMPStructMetadataWriter = new Guid("22c21f93-7ddb-411c-9b17-c5b7bd064abc");
        public static readonly Guid GUID_MetadataFormat8BIMIPTC = new Guid("0010568c-0852-4e6a-b191-5c33ac5b0430");
        public static readonly Guid GUID_MetadataFormat8BIMIPTCDigest = new Guid("1ca32285-9ccd-4786-8bd8-79539db6a006");
        public static readonly Guid GUID_MetadataFormat8BIMResolutionInfo = new Guid("739f305d-81db-43cb-ac5e-55013ef9f003");
        public static readonly Guid GUID_MetadataFormatAPE = new Guid("2e043dc2-c967-4e05-875e-618bf67e85c3");
        public static readonly Guid GUID_MetadataFormatApp0 = new Guid("79007028-268d-45d6-a3c2-354e6a504bc9");
        public static readonly Guid GUID_MetadataFormatApp1 = new Guid("8fd3dfc3-f951-492b-817f-69c2e6d9a5b0");
        public static readonly Guid GUID_MetadataFormatApp13 = new Guid("326556a2-f502-4354-9cc0-8e3f48eaf6b5");
        public static readonly Guid GUID_MetadataFormatChunkbKGD = new Guid("e14d3571-6b47-4dea-b60a-87ce0a78dfb7");
        public static readonly Guid GUID_MetadataFormatChunkcHRM = new Guid("9db3655b-2842-44b3-8067-12e9b375556a");
        public static readonly Guid GUID_MetadataFormatChunkgAMA = new Guid("f00935a5-1d5d-4cd1-81b2-9324d7eca781");
        public static readonly Guid GUID_MetadataFormatChunkhIST = new Guid("c59a82da-db74-48a4-bd6a-b69c4931ef95");
        public static readonly Guid GUID_MetadataFormatChunkiCCP = new Guid("eb4349ab-b685-450f-91b5-e802e892536c");
        public static readonly Guid GUID_MetadataFormatChunkiTXt = new Guid("c2bec729-0b68-4b77-aa0e-6295a6ac1814");
        public static readonly Guid GUID_MetadataFormatChunksRGB = new Guid("c115fd36-cc6f-4e3f-8363-524b87c6b0d9");
        public static readonly Guid GUID_MetadataFormatChunktEXt = new Guid("568d8936-c0a9-4923-905d-df2b38238fbc");
        public static readonly Guid GUID_MetadataFormatChunktIME = new Guid("6b00ae2d-e24b-460a-98b6-878bd03072fd");
        public static readonly Guid GUID_MetadataFormatDds = new Guid("4a064603-8c33-4e60-9c29-136231702d08");
        public static readonly Guid GUID_MetadataFormatExif = new Guid("1c3c4f9d-b84a-467d-9493-36cfbd59ea57");
        public static readonly Guid GUID_MetadataFormatGCE = new Guid("2a25cad8-deeb-4c69-a788-0ec2266dcafd");
        public static readonly Guid GUID_MetadataFormatGifComment = new Guid("c4b6e0e0-cfb4-4ad3-ab33-9aad2355a34a");
        public static readonly Guid GUID_MetadataFormatGps = new Guid("7134ab8a-9351-44ad-af62-448db6b502ec");
        public static readonly Guid GUID_MetadataFormatHeif = new Guid("817ef3e1-1288-45f4-a852-260d9e7cce83");
        public static readonly Guid GUID_MetadataFormatHeifHDR = new Guid("568b8d8a-1e65-438c-8968-d60e1012beb9");
        public static readonly Guid GUID_MetadataFormatIfd = new Guid("537396c6-2d8a-4bb6-9bf8-2f0a8e2a3adf");
        public static readonly Guid GUID_MetadataFormatIMD = new Guid("bd2bb086-4d52-48dd-9677-db483e85ae8f");
        public static readonly Guid GUID_MetadataFormatInterop = new Guid("ed686f8e-681f-4c8b-bd41-a8addbf6b3fc");
        public static readonly Guid GUID_MetadataFormatIPTC = new Guid("4fab0914-e129-4087-a1d1-bc812d45a7b5");
        public static readonly Guid GUID_MetadataFormatIRB = new Guid("16100d66-8570-4bb9-b92d-fda4b23ece67");
        public static readonly Guid GUID_MetadataFormatJpegChrominance = new Guid("f73d0dcf-cec6-4f85-9b0e-1c3956b1bef7");
        public static readonly Guid GUID_MetadataFormatJpegComment = new Guid("220e5f33-afd3-474e-9d31-7d4fe730f557");
        public static readonly Guid GUID_MetadataFormatJpegLuminance = new Guid("86908007-edfc-4860-8d4b-4ee6e83e6058");
        public static readonly Guid GUID_MetadataFormatLSD = new Guid("e256031e-6299-4929-b98d-5ac884afba92");
        public static readonly Guid GUID_MetadataFormatSubIfd = new Guid("58a2e128-2db9-4e57-bb14-5177891ed331");
        public static readonly Guid GUID_MetadataFormatThumbnail = new Guid("243dcee9-8703-40ee-8ef0-22a600b8058c");
        public static readonly Guid GUID_MetadataFormatUnknown = new Guid("a45e592f-9078-4a7c-adb5-4edc4fd61b1f");
        public static readonly Guid GUID_MetadataFormatWebpANIM = new Guid("6dc4fda6-78e6-4102-ae35-bcfa1edcc78b");
        public static readonly Guid GUID_MetadataFormatWebpANMF = new Guid("43c105ee-b93b-4abb-b003-a08c0d870471");
        public static readonly Guid GUID_MetadataFormatXMP = new Guid("bb5acc38-f216-4cec-a6c5-5f6e739763a9");
        public static readonly Guid GUID_MetadataFormatXMPAlt = new Guid("7b08a675-91aa-481b-a798-4da94908613b");
        public static readonly Guid GUID_MetadataFormatXMPBag = new Guid("833cca5f-dcb7-4516-806f-6596ab26dce4");
        public static readonly Guid GUID_MetadataFormatXMPSeq = new Guid("63e8df02-eb6c-456c-a224-b25e794fd648");
        public static readonly Guid GUID_MetadataFormatXMPStruct = new Guid("22383cf1-ed17-4e2e-af17-d85b8f6b30d0");
    }
}