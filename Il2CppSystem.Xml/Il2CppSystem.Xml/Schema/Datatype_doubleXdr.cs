using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020000C5 RID: 197
	public class Datatype_doubleXdr : Datatype_double
	{
		// Token: 0x06000C66 RID: 3174 RVA: 0x0003BE08 File Offset: 0x0003A008
		// Note: this type is marked as 'beforefieldinit'.
		static Datatype_doubleXdr()
		{
			Il2CppClassPointerStore<Datatype_doubleXdr>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "Datatype_doubleXdr");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Datatype_doubleXdr>.NativeClassPtr);
			Datatype_doubleXdr.NativeMethodInfoPtr_ParseValue_Public_Virtual_Object_String_XmlNameTable_IXmlNamespaceResolver_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_doubleXdr>.NativeClassPtr, 100665123);
			Datatype_doubleXdr.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_doubleXdr>.NativeClassPtr, 100665124);
		}

		// Token: 0x06000C67 RID: 3175 RVA: 0x0003BE60 File Offset: 0x0003A060
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23403, XrefRangeEnd = 23416, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_doubleXdr.NativeMethodInfoPtr_ParseValue_Public_Virtual_Object_String_XmlNameTable_IXmlNamespaceResolver_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
		}

		// Token: 0x06000C68 RID: 3176 RVA: 0x0003BEE0 File Offset: 0x0003A0E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23416, XrefRangeEnd = 23420, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Datatype_doubleXdr()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Datatype_doubleXdr>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Datatype_doubleXdr.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C69 RID: 3177 RVA: 0x000061F1 File Offset: 0x000043F1
		public Datatype_doubleXdr(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000935 RID: 2357
		private static readonly IntPtr NativeMethodInfoPtr_ParseValue_Public_Virtual_Object_String_XmlNameTable_IXmlNamespaceResolver_0;

		// Token: 0x04000936 RID: 2358
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
