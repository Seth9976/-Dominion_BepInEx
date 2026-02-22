using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020000C6 RID: 198
	public class Datatype_floatXdr : Datatype_float
	{
		// Token: 0x06000C6A RID: 3178 RVA: 0x0003BF1C File Offset: 0x0003A11C
		// Note: this type is marked as 'beforefieldinit'.
		static Datatype_floatXdr()
		{
			Il2CppClassPointerStore<Datatype_floatXdr>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "Datatype_floatXdr");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Datatype_floatXdr>.NativeClassPtr);
			Datatype_floatXdr.NativeMethodInfoPtr_ParseValue_Public_Virtual_Object_String_XmlNameTable_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_floatXdr>.NativeClassPtr, 100665125);
			Datatype_floatXdr.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_floatXdr>.NativeClassPtr, 100665126);
		}

		// Token: 0x06000C6B RID: 3179 RVA: 0x0003BF74 File Offset: 0x0003A174
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23420, XrefRangeEnd = 23429, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Object ParseValue(string s, XmlNameTable nameTable, IXmlNamespaceResolver nsmgr)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(s);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nameTable);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(nsmgr);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_floatXdr.NativeMethodInfoPtr_ParseValue_Public_Virtual_Object_String_XmlNameTable_IXmlNamespaceResolver_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000C6C RID: 3180 RVA: 0x0003BFF4 File Offset: 0x0003A1F4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23429, XrefRangeEnd = 23433, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Datatype_floatXdr()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Datatype_floatXdr>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Datatype_floatXdr.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C6D RID: 3181 RVA: 0x000061FA File Offset: 0x000043FA
		public Datatype_floatXdr(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000937 RID: 2359
		private static readonly IntPtr NativeMethodInfoPtr_ParseValue_Public_Virtual_Object_String_XmlNameTable_IXmlNamespaceResolver_0;

		// Token: 0x04000938 RID: 2360
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
