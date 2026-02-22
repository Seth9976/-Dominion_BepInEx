using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMono.Xml;
using Il2CppSystem.Collections;

namespace Il2CppSystem.Runtime.Remoting
{
	// Token: 0x02000396 RID: 918
	public class ConfigHandler : Object
	{
		// Token: 0x06003BC0 RID: 15296 RVA: 0x00119ABC File Offset: 0x00117CBC
		// Note: this type is marked as 'beforefieldinit'.
		static ConfigHandler()
		{
			Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting", "ConfigHandler");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr);
			ConfigHandler.NativeFieldInfoPtr_typeEntries = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, "typeEntries");
			ConfigHandler.NativeFieldInfoPtr_channelInstances = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, "channelInstances");
			ConfigHandler.NativeFieldInfoPtr_currentChannel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, "currentChannel");
			ConfigHandler.NativeFieldInfoPtr_currentProviderData = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, "currentProviderData");
			ConfigHandler.NativeFieldInfoPtr_currentClientUrl = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, "currentClientUrl");
			ConfigHandler.NativeFieldInfoPtr_appName = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, "appName");
			ConfigHandler.NativeFieldInfoPtr_currentXmlPath = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, "currentXmlPath");
			ConfigHandler.NativeFieldInfoPtr_onlyDelayedChannels = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, "onlyDelayedChannels");
			ConfigHandler.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, 100672118);
			ConfigHandler.NativeMethodInfoPtr_ValidatePath_Private_Void_String_Il2CppStringArray_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, 100672119);
			ConfigHandler.NativeMethodInfoPtr_CheckPath_Private_Boolean_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, 100672120);
			ConfigHandler.NativeMethodInfoPtr_OnStartParsing_Public_Virtual_Final_New_Void_SmallXmlParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, 100672121);
			ConfigHandler.NativeMethodInfoPtr_OnProcessingInstruction_Public_Virtual_Final_New_Void_String_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, 100672122);
			ConfigHandler.NativeMethodInfoPtr_OnIgnorableWhitespace_Public_Virtual_Final_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, 100672123);
			ConfigHandler.NativeMethodInfoPtr_OnStartElement_Public_Virtual_Final_New_Void_String_IAttrList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, 100672124);
			ConfigHandler.NativeMethodInfoPtr_ParseElement_Public_Void_String_IAttrList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, 100672125);
			ConfigHandler.NativeMethodInfoPtr_OnEndElement_Public_Virtual_Final_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, 100672126);
			ConfigHandler.NativeMethodInfoPtr_ReadCustomProviderData_Private_Void_String_IAttrList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, 100672127);
			ConfigHandler.NativeMethodInfoPtr_ReadLifetine_Private_Void_IAttrList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, 100672128);
			ConfigHandler.NativeMethodInfoPtr_ParseTime_Private_TimeSpan_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, 100672129);
			ConfigHandler.NativeMethodInfoPtr_ReadChannel_Private_Void_IAttrList_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, 100672130);
			ConfigHandler.NativeMethodInfoPtr_ReadProvider_Private_ProviderData_String_IAttrList_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, 100672131);
			ConfigHandler.NativeMethodInfoPtr_ReadClientActivated_Private_Void_IAttrList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, 100672132);
			ConfigHandler.NativeMethodInfoPtr_ReadServiceActivated_Private_Void_IAttrList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, 100672133);
			ConfigHandler.NativeMethodInfoPtr_ReadClientWellKnown_Private_Void_IAttrList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, 100672134);
			ConfigHandler.NativeMethodInfoPtr_ReadServiceWellKnown_Private_Void_IAttrList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, 100672135);
			ConfigHandler.NativeMethodInfoPtr_ReadInteropXml_Private_Void_IAttrList_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, 100672136);
			ConfigHandler.NativeMethodInfoPtr_ReadPreload_Private_Void_IAttrList_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, 100672137);
			ConfigHandler.NativeMethodInfoPtr_GetNotNull_Private_String_IAttrList_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, 100672138);
			ConfigHandler.NativeMethodInfoPtr_ExtractAssembly_Private_String_byref_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, 100672139);
			ConfigHandler.NativeMethodInfoPtr_OnChars_Public_Virtual_Final_New_Void_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, 100672140);
			ConfigHandler.NativeMethodInfoPtr_OnEndParsing_Public_Virtual_Final_New_Void_SmallXmlParser_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr, 100672141);
		}

		// Token: 0x06003BC1 RID: 15297 RVA: 0x00119D6C File Offset: 0x00117F6C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 349364, RefRangeEnd = 349365, XrefRangeStart = 349354, XrefRangeEnd = 349364, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ConfigHandler(bool onlyDelayedChannels)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ConfigHandler>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref onlyDelayedChannels;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigHandler.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003BC2 RID: 15298 RVA: 0x00119DB4 File Offset: 0x00117FB4
		[CallerCount(11)]
		[CachedScanResults(RefRangeStart = 349367, RefRangeEnd = 349378, XrefRangeStart = 349365, XrefRangeEnd = 349367, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ValidatePath(string element, [Optional] Il2CppStringArray paths)
		{
			if (paths == null)
			{
				paths = new Il2CppStringArray(0L);
			}
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(element);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(paths);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigHandler.NativeMethodInfoPtr_ValidatePath_Private_Void_String_Il2CppStringArray_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BC3 RID: 15299 RVA: 0x00119E18 File Offset: 0x00118018
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 349384, RefRangeEnd = 349393, XrefRangeStart = 349378, XrefRangeEnd = 349384, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool CheckPath(string path)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(path);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigHandler.NativeMethodInfoPtr_CheckPath_Private_Boolean_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003BC4 RID: 15300 RVA: 0x00119E68 File Offset: 0x00118068
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnStartParsing(SmallXmlParser parser)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parser);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigHandler.NativeMethodInfoPtr_OnStartParsing_Public_Virtual_Final_New_Void_SmallXmlParser_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003BC5 RID: 15301 RVA: 0x00119EAC File Offset: 0x001180AC
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigHandler.NativeMethodInfoPtr_OnProcessingInstruction_Public_Virtual_Final_New_Void_String_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BC6 RID: 15302 RVA: 0x00119F00 File Offset: 0x00118100
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnIgnorableWhitespace(string s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigHandler.NativeMethodInfoPtr_OnIgnorableWhitespace_Public_Virtual_Final_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003BC7 RID: 15303 RVA: 0x00119F44 File Offset: 0x00118144
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349393, XrefRangeEnd = 349400, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigHandler.NativeMethodInfoPtr_OnStartElement_Public_Virtual_Final_New_Void_String_IAttrList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BC8 RID: 15304 RVA: 0x00119F98 File Offset: 0x00118198
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 349690, RefRangeEnd = 349691, XrefRangeStart = 349400, XrefRangeEnd = 349690, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ParseElement(string name, SmallXmlParser.IAttrList attrs)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigHandler.NativeMethodInfoPtr_ParseElement_Public_Void_String_IAttrList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BC9 RID: 15305 RVA: 0x00119FEC File Offset: 0x001181EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349691, XrefRangeEnd = 349692, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnEndElement(string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigHandler.NativeMethodInfoPtr_OnEndElement_Public_Virtual_Final_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003BCA RID: 15306 RVA: 0x0011A030 File Offset: 0x00118230
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349692, XrefRangeEnd = 349719, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadCustomProviderData(string name, SmallXmlParser.IAttrList attrs)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigHandler.NativeMethodInfoPtr_ReadCustomProviderData_Private_Void_String_IAttrList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BCB RID: 15307 RVA: 0x0011A084 File Offset: 0x00118284
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 349765, RefRangeEnd = 349766, XrefRangeStart = 349719, XrefRangeEnd = 349765, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadLifetine(SmallXmlParser.IAttrList attrs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attrs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigHandler.NativeMethodInfoPtr_ReadLifetine_Private_Void_IAttrList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003BCC RID: 15308 RVA: 0x0011A0C8 File Offset: 0x001182C8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 349803, RefRangeEnd = 349807, XrefRangeStart = 349766, XrefRangeEnd = 349803, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe TimeSpan ParseTime(string s)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigHandler.NativeMethodInfoPtr_ParseTime_Private_TimeSpan_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003BCD RID: 15309 RVA: 0x0011A118 File Offset: 0x00118318
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 349855, RefRangeEnd = 349856, XrefRangeStart = 349807, XrefRangeEnd = 349855, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadChannel(SmallXmlParser.IAttrList attrs, bool isTemplate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attrs);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isTemplate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigHandler.NativeMethodInfoPtr_ReadChannel_Private_Void_IAttrList_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BCE RID: 15310 RVA: 0x0011A168 File Offset: 0x00118368
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 349901, RefRangeEnd = 349905, XrefRangeStart = 349856, XrefRangeEnd = 349901, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ProviderData ReadProvider(string name, SmallXmlParser.IAttrList attrs, bool isTemplate)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(name);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(attrs);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isTemplate;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigHandler.NativeMethodInfoPtr_ReadProvider_Private_ProviderData_String_IAttrList_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<ProviderData>(intPtr3) : null;
		}

		// Token: 0x06003BCF RID: 15311 RVA: 0x0011A1D8 File Offset: 0x001183D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349905, XrefRangeEnd = 349923, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadClientActivated(SmallXmlParser.IAttrList attrs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attrs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigHandler.NativeMethodInfoPtr_ReadClientActivated_Private_Void_IAttrList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003BD0 RID: 15312 RVA: 0x0011A21C File Offset: 0x0011841C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349923, XrefRangeEnd = 349932, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadServiceActivated(SmallXmlParser.IAttrList attrs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attrs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigHandler.NativeMethodInfoPtr_ReadServiceActivated_Private_Void_IAttrList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003BD1 RID: 15313 RVA: 0x0011A260 File Offset: 0x00118460
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 349932, XrefRangeEnd = 349944, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadClientWellKnown(SmallXmlParser.IAttrList attrs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attrs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigHandler.NativeMethodInfoPtr_ReadClientWellKnown_Private_Void_IAttrList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003BD2 RID: 15314 RVA: 0x0011A2A4 File Offset: 0x001184A4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 349974, RefRangeEnd = 349975, XrefRangeStart = 349944, XrefRangeEnd = 349974, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadServiceWellKnown(SmallXmlParser.IAttrList attrs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attrs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigHandler.NativeMethodInfoPtr_ReadServiceWellKnown_Private_Void_IAttrList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003BD3 RID: 15315 RVA: 0x0011A2E8 File Offset: 0x001184E8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 350000, RefRangeEnd = 350001, XrefRangeStart = 349975, XrefRangeEnd = 350000, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadInteropXml(SmallXmlParser.IAttrList attrs, bool isElement)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attrs);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isElement;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigHandler.NativeMethodInfoPtr_ReadInteropXml_Private_Void_IAttrList_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06003BD4 RID: 15316 RVA: 0x0011A338 File Offset: 0x00118538
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 350039, RefRangeEnd = 350040, XrefRangeStart = 350001, XrefRangeEnd = 350039, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void ReadPreload(SmallXmlParser.IAttrList attrs)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attrs);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigHandler.NativeMethodInfoPtr_ReadPreload_Private_Void_IAttrList_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003BD5 RID: 15317 RVA: 0x0011A37C File Offset: 0x0011857C
		[CallerCount(13)]
		[CachedScanResults(RefRangeStart = 350046, RefRangeEnd = 350059, XrefRangeStart = 350040, XrefRangeEnd = 350046, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string GetNotNull(SmallXmlParser.IAttrList attrs, string name)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(attrs);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(name);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigHandler.NativeMethodInfoPtr_GetNotNull_Private_String_IAttrList_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06003BD6 RID: 15318 RVA: 0x0011A3D8 File Offset: 0x001185D8
		[CallerCount(7)]
		[CachedScanResults(RefRangeStart = 350065, RefRangeEnd = 350072, XrefRangeStart = 350059, XrefRangeEnd = 350065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe string ExtractAssembly(ref string type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr = IL2CPP.ManagedStringToIl2Cpp(type);
				ptr2 = &intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(ConfigHandler.NativeMethodInfoPtr_ExtractAssembly_Private_String_byref_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				type = IL2CPP.Il2CppStringToManaged(intPtr);
				return IL2CPP.Il2CppStringToManaged(intPtr2);
			}
		}

		// Token: 0x06003BD7 RID: 15319 RVA: 0x0011A430 File Offset: 0x00118630
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnChars(string ch)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(ch);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigHandler.NativeMethodInfoPtr_OnChars_Public_Virtual_Final_New_Void_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003BD8 RID: 15320 RVA: 0x0011A474 File Offset: 0x00118674
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 350072, XrefRangeEnd = 350086, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OnEndParsing(SmallXmlParser parser)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(parser);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ConfigHandler.NativeMethodInfoPtr_OnEndParsing_Public_Virtual_Final_New_Void_SmallXmlParser_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003BD9 RID: 15321 RVA: 0x000167E8 File Offset: 0x000149E8
		public void ValidatePath(string element, params string[] paths)
		{
			this.ValidatePath(element, new Il2CppStringArray(paths));
		}

		// Token: 0x06003BDA RID: 15322 RVA: 0x000167F7 File Offset: 0x000149F7
		public ConfigHandler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000EF6 RID: 3830
		// (get) Token: 0x06003BDB RID: 15323 RVA: 0x0011A4B8 File Offset: 0x001186B8
		// (set) Token: 0x06003BDC RID: 15324 RVA: 0x00016800 File Offset: 0x00014A00
		public unsafe ArrayList typeEntries
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigHandler.NativeFieldInfoPtr_typeEntries);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigHandler.NativeFieldInfoPtr_typeEntries), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EF7 RID: 3831
		// (get) Token: 0x06003BDD RID: 15325 RVA: 0x0011A4E8 File Offset: 0x001186E8
		// (set) Token: 0x06003BDE RID: 15326 RVA: 0x0001681F File Offset: 0x00014A1F
		public unsafe ArrayList channelInstances
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigHandler.NativeFieldInfoPtr_channelInstances);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ArrayList>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigHandler.NativeFieldInfoPtr_channelInstances), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EF8 RID: 3832
		// (get) Token: 0x06003BDF RID: 15327 RVA: 0x0011A518 File Offset: 0x00118718
		// (set) Token: 0x06003BE0 RID: 15328 RVA: 0x0001683E File Offset: 0x00014A3E
		public unsafe ChannelData currentChannel
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigHandler.NativeFieldInfoPtr_currentChannel);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ChannelData>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigHandler.NativeFieldInfoPtr_currentChannel), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EF9 RID: 3833
		// (get) Token: 0x06003BE1 RID: 15329 RVA: 0x0011A548 File Offset: 0x00118748
		// (set) Token: 0x06003BE2 RID: 15330 RVA: 0x0001685D File Offset: 0x00014A5D
		public unsafe Stack currentProviderData
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigHandler.NativeFieldInfoPtr_currentProviderData);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stack>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigHandler.NativeFieldInfoPtr_currentProviderData), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000EFA RID: 3834
		// (get) Token: 0x06003BE3 RID: 15331 RVA: 0x0011A578 File Offset: 0x00118778
		// (set) Token: 0x06003BE4 RID: 15332 RVA: 0x0001687C File Offset: 0x00014A7C
		public unsafe string currentClientUrl
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigHandler.NativeFieldInfoPtr_currentClientUrl);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigHandler.NativeFieldInfoPtr_currentClientUrl), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000EFB RID: 3835
		// (get) Token: 0x06003BE5 RID: 15333 RVA: 0x0011A5A0 File Offset: 0x001187A0
		// (set) Token: 0x06003BE6 RID: 15334 RVA: 0x0001689B File Offset: 0x00014A9B
		public unsafe string appName
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigHandler.NativeFieldInfoPtr_appName);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigHandler.NativeFieldInfoPtr_appName), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000EFC RID: 3836
		// (get) Token: 0x06003BE7 RID: 15335 RVA: 0x0011A5C8 File Offset: 0x001187C8
		// (set) Token: 0x06003BE8 RID: 15336 RVA: 0x000168BA File Offset: 0x00014ABA
		public unsafe string currentXmlPath
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigHandler.NativeFieldInfoPtr_currentXmlPath);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigHandler.NativeFieldInfoPtr_currentXmlPath), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000EFD RID: 3837
		// (get) Token: 0x06003BE9 RID: 15337 RVA: 0x0011A5F0 File Offset: 0x001187F0
		// (set) Token: 0x06003BEA RID: 15338 RVA: 0x000168D9 File Offset: 0x00014AD9
		public unsafe bool onlyDelayedChannels
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigHandler.NativeFieldInfoPtr_onlyDelayedChannels);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ConfigHandler.NativeFieldInfoPtr_onlyDelayedChannels)) = value;
			}
		}

		// Token: 0x040031AB RID: 12715
		private static readonly IntPtr NativeFieldInfoPtr_typeEntries;

		// Token: 0x040031AC RID: 12716
		private static readonly IntPtr NativeFieldInfoPtr_channelInstances;

		// Token: 0x040031AD RID: 12717
		private static readonly IntPtr NativeFieldInfoPtr_currentChannel;

		// Token: 0x040031AE RID: 12718
		private static readonly IntPtr NativeFieldInfoPtr_currentProviderData;

		// Token: 0x040031AF RID: 12719
		private static readonly IntPtr NativeFieldInfoPtr_currentClientUrl;

		// Token: 0x040031B0 RID: 12720
		private static readonly IntPtr NativeFieldInfoPtr_appName;

		// Token: 0x040031B1 RID: 12721
		private static readonly IntPtr NativeFieldInfoPtr_currentXmlPath;

		// Token: 0x040031B2 RID: 12722
		private static readonly IntPtr NativeFieldInfoPtr_onlyDelayedChannels;

		// Token: 0x040031B3 RID: 12723
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

		// Token: 0x040031B4 RID: 12724
		private static readonly IntPtr NativeMethodInfoPtr_ValidatePath_Private_Void_String_Il2CppStringArray_0;

		// Token: 0x040031B5 RID: 12725
		private static readonly IntPtr NativeMethodInfoPtr_CheckPath_Private_Boolean_String_0;

		// Token: 0x040031B6 RID: 12726
		private static readonly IntPtr NativeMethodInfoPtr_OnStartParsing_Public_Virtual_Final_New_Void_SmallXmlParser_0;

		// Token: 0x040031B7 RID: 12727
		private static readonly IntPtr NativeMethodInfoPtr_OnProcessingInstruction_Public_Virtual_Final_New_Void_String_String_0;

		// Token: 0x040031B8 RID: 12728
		private static readonly IntPtr NativeMethodInfoPtr_OnIgnorableWhitespace_Public_Virtual_Final_New_Void_String_0;

		// Token: 0x040031B9 RID: 12729
		private static readonly IntPtr NativeMethodInfoPtr_OnStartElement_Public_Virtual_Final_New_Void_String_IAttrList_0;

		// Token: 0x040031BA RID: 12730
		private static readonly IntPtr NativeMethodInfoPtr_ParseElement_Public_Void_String_IAttrList_0;

		// Token: 0x040031BB RID: 12731
		private static readonly IntPtr NativeMethodInfoPtr_OnEndElement_Public_Virtual_Final_New_Void_String_0;

		// Token: 0x040031BC RID: 12732
		private static readonly IntPtr NativeMethodInfoPtr_ReadCustomProviderData_Private_Void_String_IAttrList_0;

		// Token: 0x040031BD RID: 12733
		private static readonly IntPtr NativeMethodInfoPtr_ReadLifetine_Private_Void_IAttrList_0;

		// Token: 0x040031BE RID: 12734
		private static readonly IntPtr NativeMethodInfoPtr_ParseTime_Private_TimeSpan_String_0;

		// Token: 0x040031BF RID: 12735
		private static readonly IntPtr NativeMethodInfoPtr_ReadChannel_Private_Void_IAttrList_Boolean_0;

		// Token: 0x040031C0 RID: 12736
		private static readonly IntPtr NativeMethodInfoPtr_ReadProvider_Private_ProviderData_String_IAttrList_Boolean_0;

		// Token: 0x040031C1 RID: 12737
		private static readonly IntPtr NativeMethodInfoPtr_ReadClientActivated_Private_Void_IAttrList_0;

		// Token: 0x040031C2 RID: 12738
		private static readonly IntPtr NativeMethodInfoPtr_ReadServiceActivated_Private_Void_IAttrList_0;

		// Token: 0x040031C3 RID: 12739
		private static readonly IntPtr NativeMethodInfoPtr_ReadClientWellKnown_Private_Void_IAttrList_0;

		// Token: 0x040031C4 RID: 12740
		private static readonly IntPtr NativeMethodInfoPtr_ReadServiceWellKnown_Private_Void_IAttrList_0;

		// Token: 0x040031C5 RID: 12741
		private static readonly IntPtr NativeMethodInfoPtr_ReadInteropXml_Private_Void_IAttrList_Boolean_0;

		// Token: 0x040031C6 RID: 12742
		private static readonly IntPtr NativeMethodInfoPtr_ReadPreload_Private_Void_IAttrList_0;

		// Token: 0x040031C7 RID: 12743
		private static readonly IntPtr NativeMethodInfoPtr_GetNotNull_Private_String_IAttrList_String_0;

		// Token: 0x040031C8 RID: 12744
		private static readonly IntPtr NativeMethodInfoPtr_ExtractAssembly_Private_String_byref_String_0;

		// Token: 0x040031C9 RID: 12745
		private static readonly IntPtr NativeMethodInfoPtr_OnChars_Public_Virtual_Final_New_Void_String_0;

		// Token: 0x040031CA RID: 12746
		private static readonly IntPtr NativeMethodInfoPtr_OnEndParsing_Public_Virtual_Final_New_Void_SmallXmlParser_0;
	}
}
