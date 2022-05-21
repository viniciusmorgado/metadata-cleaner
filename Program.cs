// Package: https://www.nuget.org/packages/GroupDocs.Metadata/
// https://blog.groupdocs.com/2020/12/29/remove-metadata-of-documents-and-images-using-csharp/ 

// Supported formats

// Microsoft Word: DOC, DOT, DOCX, DOCM, DOTX
// Microsoft Excel: XLSX, XLSM, XLTM, XLS
// Microsoft PowerPoint: PPTX, PPTM, PPSX, PPSM, POTX, POTM, PPT, PPS
// Microsoft Visio: VSD, VDX, VSDX, VSS, VSX
// Microsoft OneNote: ONE
// Microsoft Project: MPP
// OpenOffice: ODS, ODT, OTF, OTC
// Audio: MP3, WAV
// Video: AVI, MOV / QT, ASF, FLV
// Email: EML, MSG, VCF, VCR
// Image: BMP, GIF, JPG, JPEG, JPE, JP2, PNG, TIFF, DICOM, WEBP, HEIF / HEIC
// Archive: ZIP
// Font: TTF, TTC
// Metafile: EMF, WMF
// Adobe Photoshop: PSD
// AutoCAD: DWG, DXF
// Portable: PDF
// eBook: EPUB, DJVU, DJV
// Other: TORRENT

// The Sanitizer method remove all metadata from any supported file without filters.
MetadataHelper.RemoveAllMetadata("Assets/Marktrade.png", "C:/Users/vinic/Downloads/Marktrade-clear.png");

