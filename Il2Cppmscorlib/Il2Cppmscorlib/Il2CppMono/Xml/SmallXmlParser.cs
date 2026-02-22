using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using Il2CppSystem.Collections.Generic;
using Il2CppSystem.IO;
using Il2CppSystem.Text;

namespace Il2CppMono.Xml
{
	// Token: 0x02000012 RID: 18
	public class SmallXmlParser : Object
	{
		// Token: 0x0600006C RID: 108 RVA: 0x000242A4 File Offset: 0x000224A4
		// Note: this type is marked as 'beforefieldinit'.
		static SmallXmlParser()
		{
			Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "Mono.Xml", "SmallXmlParser");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr);
			SmallXmlParser.NativeFieldInfoPtr_handler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, "handler");
			SmallXmlParser.NativeFieldInfoPtr_reader = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, "reader");
			SmallXmlParser.NativeFieldInfoPtr_elementNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, "elementNames");
			SmallXmlParser.NativeFieldInfoPtr_xmlSpaces = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, "xmlSpaces");
			SmallXmlParser.NativeFieldInfoPtr_xmlSpace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, "xmlSpace");
			SmallXmlParser.NativeFieldInfoPtr_buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, "buffer");
			SmallXmlParser.NativeFieldInfoPtr_nameBuffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, "nameBuffer");
			SmallXmlParser.NativeFieldInfoPtr_isWhitespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, "isWhitespace");
			SmallXmlParser.NativeFieldInfoPtr_attributes = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, "attributes");
			SmallXmlParser.NativeFieldInfoPtr_line = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, "line");
			SmallXmlParser.NativeFieldInfoPtr_column = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, "column");
			SmallXmlParser.NativeFieldInfoPtr_resetColumn = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, "resetColumn");
			SmallXmlParser.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, 100663364);
			SmallXmlParser.NativeMethodInfoPtr_Error_Private_Exception_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, 100663365);
			SmallXmlParser.NativeMethodInfoPtr_UnexpectedEndError_Private_Exception_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, 100663366);
			SmallXmlParser.NativeMethodInfoPtr_IsNameChar_Private_Boolean_Char_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, 100663367);
			SmallXmlParser.NativeMethodInfoPtr_IsWhitespace_Private_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, 100663368);
			SmallXmlParser.NativeMethodInfoPtr_SkipWhitespaces_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, 100663369);
			SmallXmlParser.NativeMethodInfoPtr_HandleWhitespaces_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, 100663370);
			SmallXmlParser.NativeMethodInfoPtr_SkipWhitespaces_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, 100663371);
			SmallXmlParser.NativeMethodInfoPtr_Peek_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, 100663372);
			SmallXmlParser.NativeMethodInfoPtr_Read_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, 100663373);
			SmallXmlParser.NativeMethodInfoPtr_Expect_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, 100663374);
			SmallXmlParser.NativeMethodInfoPtr_ReadUntil_Private_String_Char_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, 100663375);
			SmallXmlParser.NativeMethodInfoPtr_ReadName_Public_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, 100663376);
			SmallXmlParser.NativeMethodInfoPtr_Parse_Public_Void_TextReader_IContentHandler_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, 100663377);
			SmallXmlParser.NativeMethodInfoPtr_Cleanup_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, 100663378);
			SmallXmlParser.NativeMethodInfoPtr_ReadContent_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, 100663379);
			SmallXmlParser.NativeMethodInfoPtr_HandleBufferedContent_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, 100663380);
			SmallXmlParser.NativeMethodInfoPtr_ReadCharacters_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, 100663381);
			SmallXmlParser.NativeMethodInfoPtr_ReadReference_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, 100663382);
			SmallXmlParser.NativeMethodInfoPtr_ReadCharacterReference_Private_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, 100663383);
			SmallXmlParser.NativeMethodInfoPtr_ReadAttribute_Private_Void_AttrListImpl_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, 100663384);
			SmallXmlParser.NativeMethodInfoPtr_ReadCDATASection_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, 100663385);
			SmallXmlParser.NativeMethodInfoPtr_ReadComment_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, 100663386);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00024590 File Offset: 0x00022790
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 258612, RefRangeEnd = 258613, XrefRangeStart = 258593, XrefRangeEnd = 258612, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SmallXmlParser()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600006E RID: 110 RVA: 0x000245CC File Offset: 0x000227CC
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 258625, RefRangeEnd = 258627, XrefRangeStart = 258613, XrefRangeEnd = 258625, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Exception Error(string msg)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(msg);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.NativeMethodInfoPtr_Error_Private_Exception_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
			}
		}

		// Token: 0x0600006F RID: 111 RVA: 0x0002461C File Offset: 0x0002281C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258627, XrefRangeEnd = 258638, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Exception UnexpectedEndError()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.NativeMethodInfoPtr_UnexpectedEndError_Private_Exception_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Exception>(intPtr3) : null;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x0002465C File Offset: 0x0002285C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 258639, RefRangeEnd = 258641, XrefRangeStart = 258638, XrefRangeEnd = 258639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsNameChar(char c, bool start)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref start;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.NativeMethodInfoPtr_IsNameChar_Private_Boolean_Char_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x000246B4 File Offset: 0x000228B4
		[CallerCount(0)]
		public unsafe bool IsWhitespace(int c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.NativeMethodInfoPtr_IsWhitespace_Private_Boolean_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00024700 File Offset: 0x00022900
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258641, XrefRangeEnd = 258642, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SkipWhitespaces()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.NativeMethodInfoPtr_SkipWhitespaces_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000073 RID: 115 RVA: 0x00024734 File Offset: 0x00022934
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258642, XrefRangeEnd = 258645, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleWhitespaces()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.NativeMethodInfoPtr_HandleWhitespaces_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000074 RID: 116 RVA: 0x00024768 File Offset: 0x00022968
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 258647, RefRangeEnd = 258651, XrefRangeStart = 258645, XrefRangeEnd = 258647, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SkipWhitespaces(bool expected)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref expected;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.NativeMethodInfoPtr_SkipWhitespaces_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000075 RID: 117 RVA: 0x000247A8 File Offset: 0x000229A8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258651, XrefRangeEnd = 258652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Peek()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.NativeMethodInfoPtr_Peek_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000076 RID: 118 RVA: 0x000247E4 File Offset: 0x000229E4
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 258652, RefRangeEnd = 258654, XrefRangeStart = 258652, XrefRangeEnd = 258652, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int Read()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.NativeMethodInfoPtr_Read_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00024820 File Offset: 0x00022A20
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 258655, RefRangeEnd = 258659, XrefRangeStart = 258654, XrefRangeEnd = 258655, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Expect(int c)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref c;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.NativeMethodInfoPtr_Expect_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00024860 File Offset: 0x00022A60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 258665, RefRangeEnd = 258666, XrefRangeStart = 258659, XrefRangeEnd = 258665, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ReadUntil(char until, bool handleReferences)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref until;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref handleReferences;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.NativeMethodInfoPtr_ReadUntil_Private_String_Char_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000079 RID: 121 RVA: 0x000248B4 File Offset: 0x00022AB4
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 258674, RefRangeEnd = 258677, XrefRangeStart = 258666, XrefRangeEnd = 258674, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ReadName()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.NativeMethodInfoPtr_ReadName_Public_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0600007A RID: 122 RVA: 0x000248EC File Offset: 0x00022AEC
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 258687, RefRangeEnd = 258690, XrefRangeStart = 258677, XrefRangeEnd = 258687, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Parse(TextReader input, SmallXmlParser.IContentHandler handler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(input);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(handler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.NativeMethodInfoPtr_Parse_Public_Void_TextReader_IContentHandler_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00024940 File Offset: 0x00022B40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258690, XrefRangeEnd = 258692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Cleanup()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.NativeMethodInfoPtr_Cleanup_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00024974 File Offset: 0x00022B74
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 258714, RefRangeEnd = 258715, XrefRangeStart = 258692, XrefRangeEnd = 258714, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadContent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.NativeMethodInfoPtr_ReadContent_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007D RID: 125 RVA: 0x000249A8 File Offset: 0x00022BA8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 258721, RefRangeEnd = 258722, XrefRangeStart = 258715, XrefRangeEnd = 258721, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void HandleBufferedContent()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.NativeMethodInfoPtr_HandleBufferedContent_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007E RID: 126 RVA: 0x000249DC File Offset: 0x00022BDC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258722, XrefRangeEnd = 258729, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadCharacters()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.NativeMethodInfoPtr_ReadCharacters_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00024A10 File Offset: 0x00022C10
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 258758, RefRangeEnd = 258763, XrefRangeStart = 258729, XrefRangeEnd = 258758, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadReference()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.NativeMethodInfoPtr_ReadReference_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00024A44 File Offset: 0x00022C44
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 258764, RefRangeEnd = 258766, XrefRangeStart = 258763, XrefRangeEnd = 258764, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int ReadCharacterReference()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.NativeMethodInfoPtr_ReadCharacterReference_Private_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00024A80 File Offset: 0x00022C80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258766, XrefRangeEnd = 258778, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadAttribute(SmallXmlParser.AttrListImpl a)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.NativeMethodInfoPtr_ReadAttribute_Private_Void_AttrListImpl_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000082 RID: 130 RVA: 0x00024AC4 File Offset: 0x00022CC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258778, XrefRangeEnd = 258784, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadCDATASection()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.NativeMethodInfoPtr_ReadCDATASection_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00024AF8 File Offset: 0x00022CF8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 258789, RefRangeEnd = 258790, XrefRangeStart = 258784, XrefRangeEnd = 258789, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadComment()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.NativeMethodInfoPtr_ReadComment_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00002204 File Offset: 0x00000404
		public SmallXmlParser(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000085 RID: 133 RVA: 0x00024B2C File Offset: 0x00022D2C
		// (set) Token: 0x06000086 RID: 134 RVA: 0x0000220D File Offset: 0x0000040D
		public unsafe SmallXmlParser.IContentHandler handler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParser.NativeFieldInfoPtr_handler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SmallXmlParser.IContentHandler>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParser.NativeFieldInfoPtr_handler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000087 RID: 135 RVA: 0x00024B5C File Offset: 0x00022D5C
		// (set) Token: 0x06000088 RID: 136 RVA: 0x0000222C File Offset: 0x0000042C
		public unsafe TextReader reader
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParser.NativeFieldInfoPtr_reader);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextReader>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParser.NativeFieldInfoPtr_reader), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000089 RID: 137 RVA: 0x00024B8C File Offset: 0x00022D8C
		// (set) Token: 0x0600008A RID: 138 RVA: 0x0000224B File Offset: 0x0000044B
		public unsafe Stack elementNames
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParser.NativeFieldInfoPtr_elementNames);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParser.NativeFieldInfoPtr_elementNames), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600008B RID: 139 RVA: 0x00024BBC File Offset: 0x00022DBC
		// (set) Token: 0x0600008C RID: 140 RVA: 0x0000226A File Offset: 0x0000046A
		public unsafe Stack xmlSpaces
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParser.NativeFieldInfoPtr_xmlSpaces);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParser.NativeFieldInfoPtr_xmlSpaces), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600008D RID: 141 RVA: 0x00024BEC File Offset: 0x00022DEC
		// (set) Token: 0x0600008E RID: 142 RVA: 0x00002289 File Offset: 0x00000489
		public unsafe string xmlSpace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParser.NativeFieldInfoPtr_xmlSpace);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParser.NativeFieldInfoPtr_xmlSpace), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x0600008F RID: 143 RVA: 0x00024C14 File Offset: 0x00022E14
		// (set) Token: 0x06000090 RID: 144 RVA: 0x000022A8 File Offset: 0x000004A8
		public unsafe StringBuilder buffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParser.NativeFieldInfoPtr_buffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParser.NativeFieldInfoPtr_buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000091 RID: 145 RVA: 0x00024C44 File Offset: 0x00022E44
		// (set) Token: 0x06000092 RID: 146 RVA: 0x000022C7 File Offset: 0x000004C7
		public unsafe Il2CppStructArray<char> nameBuffer
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParser.NativeFieldInfoPtr_nameBuffer);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<char>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParser.NativeFieldInfoPtr_nameBuffer), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000093 RID: 147 RVA: 0x00024C74 File Offset: 0x00022E74
		// (set) Token: 0x06000094 RID: 148 RVA: 0x000022E6 File Offset: 0x000004E6
		public unsafe bool isWhitespace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParser.NativeFieldInfoPtr_isWhitespace);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParser.NativeFieldInfoPtr_isWhitespace)) = value;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000095 RID: 149 RVA: 0x00024C9C File Offset: 0x00022E9C
		// (set) Token: 0x06000096 RID: 150 RVA: 0x00002301 File Offset: 0x00000501
		public unsafe SmallXmlParser.AttrListImpl attributes
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParser.NativeFieldInfoPtr_attributes);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SmallXmlParser.AttrListImpl>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParser.NativeFieldInfoPtr_attributes), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000097 RID: 151 RVA: 0x00024CCC File Offset: 0x00022ECC
		// (set) Token: 0x06000098 RID: 152 RVA: 0x00002320 File Offset: 0x00000520
		public unsafe int line
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParser.NativeFieldInfoPtr_line);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParser.NativeFieldInfoPtr_line)) = value;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000099 RID: 153 RVA: 0x00024CF4 File Offset: 0x00022EF4
		// (set) Token: 0x0600009A RID: 154 RVA: 0x0000233B File Offset: 0x0000053B
		public unsafe int column
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParser.NativeFieldInfoPtr_column);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParser.NativeFieldInfoPtr_column)) = value;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600009B RID: 155 RVA: 0x00024D1C File Offset: 0x00022F1C
		// (set) Token: 0x0600009C RID: 156 RVA: 0x00002356 File Offset: 0x00000556
		public unsafe bool resetColumn
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParser.NativeFieldInfoPtr_resetColumn);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParser.NativeFieldInfoPtr_resetColumn)) = value;
			}
		}

		// Token: 0x0400006C RID: 108
		private static readonly IntPtr NativeFieldInfoPtr_handler;

		// Token: 0x0400006D RID: 109
		private static readonly IntPtr NativeFieldInfoPtr_reader;

		// Token: 0x0400006E RID: 110
		private static readonly IntPtr NativeFieldInfoPtr_elementNames;

		// Token: 0x0400006F RID: 111
		private static readonly IntPtr NativeFieldInfoPtr_xmlSpaces;

		// Token: 0x04000070 RID: 112
		private static readonly IntPtr NativeFieldInfoPtr_xmlSpace;

		// Token: 0x04000071 RID: 113
		private static readonly IntPtr NativeFieldInfoPtr_buffer;

		// Token: 0x04000072 RID: 114
		private static readonly IntPtr NativeFieldInfoPtr_nameBuffer;

		// Token: 0x04000073 RID: 115
		private static readonly IntPtr NativeFieldInfoPtr_isWhitespace;

		// Token: 0x04000074 RID: 116
		private static readonly IntPtr NativeFieldInfoPtr_attributes;

		// Token: 0x04000075 RID: 117
		private static readonly IntPtr NativeFieldInfoPtr_line;

		// Token: 0x04000076 RID: 118
		private static readonly IntPtr NativeFieldInfoPtr_column;

		// Token: 0x04000077 RID: 119
		private static readonly IntPtr NativeFieldInfoPtr_resetColumn;

		// Token: 0x04000078 RID: 120
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000079 RID: 121
		private static readonly IntPtr NativeMethodInfoPtr_Error_Private_Exception_String_0;

		// Token: 0x0400007A RID: 122
		private static readonly IntPtr NativeMethodInfoPtr_UnexpectedEndError_Private_Exception_0;

		// Token: 0x0400007B RID: 123
		private static readonly IntPtr NativeMethodInfoPtr_IsNameChar_Private_Boolean_Char_Boolean_0;

		// Token: 0x0400007C RID: 124
		private static readonly IntPtr NativeMethodInfoPtr_IsWhitespace_Private_Boolean_Int32_0;

		// Token: 0x0400007D RID: 125
		private static readonly IntPtr NativeMethodInfoPtr_SkipWhitespaces_Public_Void_0;

		// Token: 0x0400007E RID: 126
		private static readonly IntPtr NativeMethodInfoPtr_HandleWhitespaces_Private_Void_0;

		// Token: 0x0400007F RID: 127
		private static readonly IntPtr NativeMethodInfoPtr_SkipWhitespaces_Public_Void_Boolean_0;

		// Token: 0x04000080 RID: 128
		private static readonly IntPtr NativeMethodInfoPtr_Peek_Private_Int32_0;

		// Token: 0x04000081 RID: 129
		private static readonly IntPtr NativeMethodInfoPtr_Read_Private_Int32_0;

		// Token: 0x04000082 RID: 130
		private static readonly IntPtr NativeMethodInfoPtr_Expect_Public_Void_Int32_0;

		// Token: 0x04000083 RID: 131
		private static readonly IntPtr NativeMethodInfoPtr_ReadUntil_Private_String_Char_Boolean_0;

		// Token: 0x04000084 RID: 132
		private static readonly IntPtr NativeMethodInfoPtr_ReadName_Public_String_0;

		// Token: 0x04000085 RID: 133
		private static readonly IntPtr NativeMethodInfoPtr_Parse_Public_Void_TextReader_IContentHandler_0;

		// Token: 0x04000086 RID: 134
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Private_Void_0;

		// Token: 0x04000087 RID: 135
		private static readonly IntPtr NativeMethodInfoPtr_ReadContent_Public_Void_0;

		// Token: 0x04000088 RID: 136
		private static readonly IntPtr NativeMethodInfoPtr_HandleBufferedContent_Private_Void_0;

		// Token: 0x04000089 RID: 137
		private static readonly IntPtr NativeMethodInfoPtr_ReadCharacters_Private_Void_0;

		// Token: 0x0400008A RID: 138
		private static readonly IntPtr NativeMethodInfoPtr_ReadReference_Private_Void_0;

		// Token: 0x0400008B RID: 139
		private static readonly IntPtr NativeMethodInfoPtr_ReadCharacterReference_Private_Int32_0;

		// Token: 0x0400008C RID: 140
		private static readonly IntPtr NativeMethodInfoPtr_ReadAttribute_Private_Void_AttrListImpl_0;

		// Token: 0x0400008D RID: 141
		private static readonly IntPtr NativeMethodInfoPtr_ReadCDATASection_Private_Void_0;

		// Token: 0x0400008E RID: 142
		private static readonly IntPtr NativeMethodInfoPtr_ReadComment_Private_Void_0;

		// Token: 0x02000536 RID: 1334
		public class IContentHandler : Il2CppObjectBase
		{
			// Token: 0x06004D68 RID: 19816 RVA: 0x0015D738 File Offset: 0x0015B938
			// Note: this type is marked as 'beforefieldinit'.
			static IContentHandler()
			{
				Il2CppClassPointerStore<SmallXmlParser.IContentHandler>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, "IContentHandler");
				SmallXmlParser.IContentHandler.NativeMethodInfoPtr_OnStartParsing_Public_Abstract_Virtual_New_Void_SmallXmlParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser.IContentHandler>.NativeClassPtr, 100663387);
				SmallXmlParser.IContentHandler.NativeMethodInfoPtr_OnEndParsing_Public_Abstract_Virtual_New_Void_SmallXmlParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser.IContentHandler>.NativeClassPtr, 100663388);
				SmallXmlParser.IContentHandler.NativeMethodInfoPtr_OnStartElement_Public_Abstract_Virtual_New_Void_String_IAttrList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser.IContentHandler>.NativeClassPtr, 100663389);
				SmallXmlParser.IContentHandler.NativeMethodInfoPtr_OnEndElement_Public_Abstract_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser.IContentHandler>.NativeClassPtr, 100663390);
				SmallXmlParser.IContentHandler.NativeMethodInfoPtr_OnProcessingInstruction_Public_Abstract_Virtual_New_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser.IContentHandler>.NativeClassPtr, 100663391);
				SmallXmlParser.IContentHandler.NativeMethodInfoPtr_OnChars_Public_Abstract_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser.IContentHandler>.NativeClassPtr, 100663392);
				SmallXmlParser.IContentHandler.NativeMethodInfoPtr_OnIgnorableWhitespace_Public_Abstract_Virtual_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser.IContentHandler>.NativeClassPtr, 100663393);
			}

			// Token: 0x06004D69 RID: 19817 RVA: 0x0015D7E8 File Offset: 0x0015B9E8
			[CallerCount(0)]
			public unsafe virtual void OnStartParsing(SmallXmlParser parser)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(parser);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SmallXmlParser.IContentHandler.NativeMethodInfoPtr_OnStartParsing_Public_Abstract_Virtual_New_Void_SmallXmlParser_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004D6A RID: 19818 RVA: 0x0015D838 File Offset: 0x0015BA38
			[CallerCount(0)]
			public unsafe virtual void OnEndParsing(SmallXmlParser parser)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(parser);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SmallXmlParser.IContentHandler.NativeMethodInfoPtr_OnEndParsing_Public_Abstract_Virtual_New_Void_SmallXmlParser_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004D6B RID: 19819 RVA: 0x0015D888 File Offset: 0x0015BA88
			[CallerCount(0)]
			public unsafe virtual void OnStartElement(string name, SmallXmlParser.IAttrList attrs)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attrs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SmallXmlParser.IContentHandler.NativeMethodInfoPtr_OnStartElement_Public_Abstract_Virtual_New_Void_String_IAttrList_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004D6C RID: 19820 RVA: 0x0015D8E8 File Offset: 0x0015BAE8
			[CallerCount(0)]
			public unsafe virtual void OnEndElement(string name)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SmallXmlParser.IContentHandler.NativeMethodInfoPtr_OnEndElement_Public_Abstract_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004D6D RID: 19821 RVA: 0x0015D938 File Offset: 0x0015BB38
			[CallerCount(0)]
			public unsafe virtual void OnProcessingInstruction(string name, string text)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(text);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SmallXmlParser.IContentHandler.NativeMethodInfoPtr_OnProcessingInstruction_Public_Abstract_Virtual_New_Void_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004D6E RID: 19822 RVA: 0x0015D998 File Offset: 0x0015BB98
			[CallerCount(0)]
			public unsafe virtual void OnChars(string text)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SmallXmlParser.IContentHandler.NativeMethodInfoPtr_OnChars_Public_Abstract_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004D6F RID: 19823 RVA: 0x0015D9E8 File Offset: 0x0015BBE8
			[CallerCount(0)]
			public unsafe virtual void OnIgnorableWhitespace(string text)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(text);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SmallXmlParser.IContentHandler.NativeMethodInfoPtr_OnIgnorableWhitespace_Public_Abstract_Virtual_New_Void_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06004D70 RID: 19824 RVA: 0x0001D4FC File Offset: 0x0001B6FC
			public IContentHandler(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04003E7A RID: 15994
			private static readonly IntPtr NativeMethodInfoPtr_OnStartParsing_Public_Abstract_Virtual_New_Void_SmallXmlParser_0;

			// Token: 0x04003E7B RID: 15995
			private static readonly IntPtr NativeMethodInfoPtr_OnEndParsing_Public_Abstract_Virtual_New_Void_SmallXmlParser_0;

			// Token: 0x04003E7C RID: 15996
			private static readonly IntPtr NativeMethodInfoPtr_OnStartElement_Public_Abstract_Virtual_New_Void_String_IAttrList_0;

			// Token: 0x04003E7D RID: 15997
			private static readonly IntPtr NativeMethodInfoPtr_OnEndElement_Public_Abstract_Virtual_New_Void_String_0;

			// Token: 0x04003E7E RID: 15998
			private static readonly IntPtr NativeMethodInfoPtr_OnProcessingInstruction_Public_Abstract_Virtual_New_Void_String_String_0;

			// Token: 0x04003E7F RID: 15999
			private static readonly IntPtr NativeMethodInfoPtr_OnChars_Public_Abstract_Virtual_New_Void_String_0;

			// Token: 0x04003E80 RID: 16000
			private static readonly IntPtr NativeMethodInfoPtr_OnIgnorableWhitespace_Public_Abstract_Virtual_New_Void_String_0;
		}

		// Token: 0x02000537 RID: 1335
		public class IAttrList : Il2CppObjectBase
		{
			// Token: 0x06004D71 RID: 19825 RVA: 0x0015DA38 File Offset: 0x0015BC38
			// Note: this type is marked as 'beforefieldinit'.
			static IAttrList()
			{
				Il2CppClassPointerStore<SmallXmlParser.IAttrList>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, "IAttrList");
				SmallXmlParser.IAttrList.NativeMethodInfoPtr_get_Length_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser.IAttrList>.NativeClassPtr, 100663394);
				SmallXmlParser.IAttrList.NativeMethodInfoPtr_GetName_Public_Abstract_Virtual_New_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser.IAttrList>.NativeClassPtr, 100663395);
				SmallXmlParser.IAttrList.NativeMethodInfoPtr_GetValue_Public_Abstract_Virtual_New_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser.IAttrList>.NativeClassPtr, 100663396);
				SmallXmlParser.IAttrList.NativeMethodInfoPtr_GetValue_Public_Abstract_Virtual_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser.IAttrList>.NativeClassPtr, 100663397);
				SmallXmlParser.IAttrList.NativeMethodInfoPtr_get_Names_Public_Abstract_Virtual_New_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser.IAttrList>.NativeClassPtr, 100663398);
				SmallXmlParser.IAttrList.NativeMethodInfoPtr_get_Values_Public_Abstract_Virtual_New_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser.IAttrList>.NativeClassPtr, 100663399);
			}

			// Token: 0x170013B6 RID: 5046
			// (get) Token: 0x06004D72 RID: 19826 RVA: 0x0015DAD4 File Offset: 0x0015BCD4
			public unsafe virtual int Length
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SmallXmlParser.IAttrList.NativeMethodInfoPtr_get_Length_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004D73 RID: 19827 RVA: 0x0015DB1C File Offset: 0x0015BD1C
			[CallerCount(0)]
			public unsafe virtual string GetName(int i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref i;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SmallXmlParser.IAttrList.NativeMethodInfoPtr_GetName_Public_Abstract_Virtual_New_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06004D74 RID: 19828 RVA: 0x0015DB6C File Offset: 0x0015BD6C
			[CallerCount(0)]
			public unsafe virtual string GetValue(int i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref i;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SmallXmlParser.IAttrList.NativeMethodInfoPtr_GetValue_Public_Abstract_Virtual_New_String_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06004D75 RID: 19829 RVA: 0x0015DBBC File Offset: 0x0015BDBC
			[CallerCount(0)]
			public unsafe virtual string GetValue(string name)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SmallXmlParser.IAttrList.NativeMethodInfoPtr_GetValue_Public_Abstract_Virtual_New_String_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x170013B7 RID: 5047
			// (get) Token: 0x06004D76 RID: 19830 RVA: 0x0015DC10 File Offset: 0x0015BE10
			public unsafe virtual Il2CppStringArray Names
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SmallXmlParser.IAttrList.NativeMethodInfoPtr_get_Names_Public_Abstract_Virtual_New_get_Il2CppStringArray_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
				}
			}

			// Token: 0x170013B8 RID: 5048
			// (get) Token: 0x06004D77 RID: 19831 RVA: 0x0015DC5C File Offset: 0x0015BE5C
			public unsafe virtual Il2CppStringArray Values
			{
				[CallerCount(0)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SmallXmlParser.IAttrList.NativeMethodInfoPtr_get_Values_Public_Abstract_Virtual_New_get_Il2CppStringArray_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
				}
			}

			// Token: 0x06004D78 RID: 19832 RVA: 0x0001D505 File Offset: 0x0001B705
			public IAttrList(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x04003E81 RID: 16001
			private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_Abstract_Virtual_New_get_Int32_0;

			// Token: 0x04003E82 RID: 16002
			private static readonly IntPtr NativeMethodInfoPtr_GetName_Public_Abstract_Virtual_New_String_Int32_0;

			// Token: 0x04003E83 RID: 16003
			private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Abstract_Virtual_New_String_Int32_0;

			// Token: 0x04003E84 RID: 16004
			private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Abstract_Virtual_New_String_String_0;

			// Token: 0x04003E85 RID: 16005
			private static readonly IntPtr NativeMethodInfoPtr_get_Names_Public_Abstract_Virtual_New_get_Il2CppStringArray_0;

			// Token: 0x04003E86 RID: 16006
			private static readonly IntPtr NativeMethodInfoPtr_get_Values_Public_Abstract_Virtual_New_get_Il2CppStringArray_0;
		}

		// Token: 0x02000538 RID: 1336
		public class AttrListImpl : Object
		{
			// Token: 0x06004D79 RID: 19833 RVA: 0x0015DCA8 File Offset: 0x0015BEA8
			// Note: this type is marked as 'beforefieldinit'.
			static AttrListImpl()
			{
				Il2CppClassPointerStore<SmallXmlParser.AttrListImpl>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SmallXmlParser>.NativeClassPtr, "AttrListImpl");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SmallXmlParser.AttrListImpl>.NativeClassPtr);
				SmallXmlParser.AttrListImpl.NativeFieldInfoPtr_attrNames = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmallXmlParser.AttrListImpl>.NativeClassPtr, "attrNames");
				SmallXmlParser.AttrListImpl.NativeFieldInfoPtr_attrValues = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SmallXmlParser.AttrListImpl>.NativeClassPtr, "attrValues");
				SmallXmlParser.AttrListImpl.NativeMethodInfoPtr_get_Length_Public_Virtual_Final_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser.AttrListImpl>.NativeClassPtr, 100663400);
				SmallXmlParser.AttrListImpl.NativeMethodInfoPtr_GetName_Public_Virtual_Final_New_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser.AttrListImpl>.NativeClassPtr, 100663401);
				SmallXmlParser.AttrListImpl.NativeMethodInfoPtr_GetValue_Public_Virtual_Final_New_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser.AttrListImpl>.NativeClassPtr, 100663402);
				SmallXmlParser.AttrListImpl.NativeMethodInfoPtr_GetValue_Public_Virtual_Final_New_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser.AttrListImpl>.NativeClassPtr, 100663403);
				SmallXmlParser.AttrListImpl.NativeMethodInfoPtr_get_Names_Public_Virtual_Final_New_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser.AttrListImpl>.NativeClassPtr, 100663404);
				SmallXmlParser.AttrListImpl.NativeMethodInfoPtr_get_Values_Public_Virtual_Final_New_get_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser.AttrListImpl>.NativeClassPtr, 100663405);
				SmallXmlParser.AttrListImpl.NativeMethodInfoPtr_Clear_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser.AttrListImpl>.NativeClassPtr, 100663406);
				SmallXmlParser.AttrListImpl.NativeMethodInfoPtr_Add_Internal_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser.AttrListImpl>.NativeClassPtr, 100663407);
				SmallXmlParser.AttrListImpl.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SmallXmlParser.AttrListImpl>.NativeClassPtr, 100663408);
			}

			// Token: 0x170013BB RID: 5051
			// (get) Token: 0x06004D7A RID: 19834 RVA: 0x0015DDB0 File Offset: 0x0015BFB0
			public unsafe virtual int Length
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258544, XrefRangeEnd = 258545, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.AttrListImpl.NativeMethodInfoPtr_get_Length_Public_Virtual_Final_New_get_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06004D7B RID: 19835 RVA: 0x0015DDEC File Offset: 0x0015BFEC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258545, XrefRangeEnd = 258547, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual string GetName(int i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref i;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.AttrListImpl.NativeMethodInfoPtr_GetName_Public_Virtual_Final_New_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06004D7C RID: 19836 RVA: 0x0015DE30 File Offset: 0x0015C030
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258547, XrefRangeEnd = 258549, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual string GetValue(int i)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref i;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.AttrListImpl.NativeMethodInfoPtr_GetValue_Public_Virtual_Final_New_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x06004D7D RID: 19837 RVA: 0x0015DE74 File Offset: 0x0015C074
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258549, XrefRangeEnd = 258556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe virtual string GetValue(string name)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.AttrListImpl.NativeMethodInfoPtr_GetValue_Public_Virtual_Final_New_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return IL2CPP.Il2CppStringToManaged(intPtr);
				}
			}

			// Token: 0x170013BC RID: 5052
			// (get) Token: 0x06004D7E RID: 19838 RVA: 0x0015DEBC File Offset: 0x0015C0BC
			public unsafe virtual Il2CppStringArray Names
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258556, XrefRangeEnd = 258560, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.AttrListImpl.NativeMethodInfoPtr_get_Names_Public_Virtual_Final_New_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
				}
			}

			// Token: 0x170013BD RID: 5053
			// (get) Token: 0x06004D7F RID: 19839 RVA: 0x0015DEFC File Offset: 0x0015C0FC
			public unsafe virtual Il2CppStringArray Values
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 258560, XrefRangeEnd = 258564, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.AttrListImpl.NativeMethodInfoPtr_get_Values_Public_Virtual_Final_New_get_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr3) : null;
				}
			}

			// Token: 0x06004D80 RID: 19840 RVA: 0x0015DF3C File Offset: 0x0015C13C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 258570, RefRangeEnd = 258572, XrefRangeStart = 258564, XrefRangeEnd = 258570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Clear()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.AttrListImpl.NativeMethodInfoPtr_Clear_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004D81 RID: 19841 RVA: 0x0015DF70 File Offset: 0x0015C170
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 258578, RefRangeEnd = 258579, XrefRangeStart = 258572, XrefRangeEnd = 258578, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Add(string name, string value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.AttrListImpl.NativeMethodInfoPtr_Add_Internal_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004D82 RID: 19842 RVA: 0x0015DFC4 File Offset: 0x0015C1C4
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 258590, RefRangeEnd = 258593, XrefRangeStart = 258579, XrefRangeEnd = 258590, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe AttrListImpl()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SmallXmlParser.AttrListImpl>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SmallXmlParser.AttrListImpl.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06004D83 RID: 19843 RVA: 0x0001D50E File Offset: 0x0001B70E
			public AttrListImpl(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170013B9 RID: 5049
			// (get) Token: 0x06004D84 RID: 19844 RVA: 0x0015E000 File Offset: 0x0015C200
			// (set) Token: 0x06004D85 RID: 19845 RVA: 0x0001D517 File Offset: 0x0001B717
			public unsafe List<string> attrNames
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParser.AttrListImpl.NativeFieldInfoPtr_attrNames);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParser.AttrListImpl.NativeFieldInfoPtr_attrNames), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170013BA RID: 5050
			// (get) Token: 0x06004D86 RID: 19846 RVA: 0x0015E030 File Offset: 0x0015C230
			// (set) Token: 0x06004D87 RID: 19847 RVA: 0x0001D536 File Offset: 0x0001B736
			public unsafe List<string> attrValues
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParser.AttrListImpl.NativeFieldInfoPtr_attrValues);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SmallXmlParser.AttrListImpl.NativeFieldInfoPtr_attrValues), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04003E87 RID: 16007
			private static readonly IntPtr NativeFieldInfoPtr_attrNames;

			// Token: 0x04003E88 RID: 16008
			private static readonly IntPtr NativeFieldInfoPtr_attrValues;

			// Token: 0x04003E89 RID: 16009
			private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_Virtual_Final_New_get_Int32_0;

			// Token: 0x04003E8A RID: 16010
			private static readonly IntPtr NativeMethodInfoPtr_GetName_Public_Virtual_Final_New_String_Int32_0;

			// Token: 0x04003E8B RID: 16011
			private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Final_New_String_Int32_0;

			// Token: 0x04003E8C RID: 16012
			private static readonly IntPtr NativeMethodInfoPtr_GetValue_Public_Virtual_Final_New_String_String_0;

			// Token: 0x04003E8D RID: 16013
			private static readonly IntPtr NativeMethodInfoPtr_get_Names_Public_Virtual_Final_New_get_Il2CppStringArray_0;

			// Token: 0x04003E8E RID: 16014
			private static readonly IntPtr NativeMethodInfoPtr_get_Values_Public_Virtual_Final_New_get_Il2CppStringArray_0;

			// Token: 0x04003E8F RID: 16015
			private static readonly IntPtr NativeMethodInfoPtr_Clear_Internal_Void_0;

			// Token: 0x04003E90 RID: 16016
			private static readonly IntPtr NativeMethodInfoPtr_Add_Internal_Void_String_String_0;

			// Token: 0x04003E91 RID: 16017
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
