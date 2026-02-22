using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.Remoting.Metadata
{
	// Token: 0x020003D9 RID: 985
	public class SoapAttribute : Attribute
	{
		// Token: 0x06003E9C RID: 16028 RVA: 0x0012455C File Offset: 0x0012275C
		// Note: this type is marked as 'beforefieldinit'.
		static SoapAttribute()
		{
			Il2CppClassPointerStore<SoapAttribute>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Metadata", "SoapAttribute");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SoapAttribute>.NativeClassPtr);
			SoapAttribute.NativeFieldInfoPtr__useAttribute = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoapAttribute>.NativeClassPtr, "_useAttribute");
			SoapAttribute.NativeFieldInfoPtr_ProtXmlNamespace = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoapAttribute>.NativeClassPtr, "ProtXmlNamespace");
			SoapAttribute.NativeFieldInfoPtr_ReflectInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SoapAttribute>.NativeClassPtr, "ReflectInfo");
			SoapAttribute.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapAttribute>.NativeClassPtr, 100672489);
			SoapAttribute.NativeMethodInfoPtr_get_UseAttribute_Public_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapAttribute>.NativeClassPtr, 100672490);
			SoapAttribute.NativeMethodInfoPtr_get_XmlNamespace_Public_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapAttribute>.NativeClassPtr, 100672491);
			SoapAttribute.NativeMethodInfoPtr_SetReflectionObject_Internal_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SoapAttribute>.NativeClassPtr, 100672492);
		}

		// Token: 0x06003E9D RID: 16029 RVA: 0x00124618 File Offset: 0x00122818
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SoapAttribute()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SoapAttribute>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SoapAttribute.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000FBA RID: 4026
		// (get) Token: 0x06003E9E RID: 16030 RVA: 0x00124654 File Offset: 0x00122854
		public unsafe virtual bool UseAttribute
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SoapAttribute.NativeMethodInfoPtr_get_UseAttribute_Public_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000FBB RID: 4027
		// (get) Token: 0x06003E9F RID: 16031 RVA: 0x0012469C File Offset: 0x0012289C
		public unsafe virtual string XmlNamespace
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SoapAttribute.NativeMethodInfoPtr_get_XmlNamespace_Public_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003EA0 RID: 16032 RVA: 0x001246E0 File Offset: 0x001228E0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 14770, RefRangeEnd = 14771, XrefRangeStart = 14770, XrefRangeEnd = 14771, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void SetReflectionObject(Object reflectionObject)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(reflectionObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SoapAttribute.NativeMethodInfoPtr_SetReflectionObject_Internal_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003EA1 RID: 16033 RVA: 0x0001799D File Offset: 0x00015B9D
		public SoapAttribute(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000FB7 RID: 4023
		// (get) Token: 0x06003EA2 RID: 16034 RVA: 0x00124730 File Offset: 0x00122930
		// (set) Token: 0x06003EA3 RID: 16035 RVA: 0x000179A6 File Offset: 0x00015BA6
		public unsafe bool _useAttribute
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapAttribute.NativeFieldInfoPtr__useAttribute);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapAttribute.NativeFieldInfoPtr__useAttribute)) = value;
			}
		}

		// Token: 0x17000FB8 RID: 4024
		// (get) Token: 0x06003EA4 RID: 16036 RVA: 0x00124758 File Offset: 0x00122958
		// (set) Token: 0x06003EA5 RID: 16037 RVA: 0x000179C1 File Offset: 0x00015BC1
		public unsafe string ProtXmlNamespace
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapAttribute.NativeFieldInfoPtr_ProtXmlNamespace);
				return IL2CPP.Il2CppStringToManaged(*intPtr);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapAttribute.NativeFieldInfoPtr_ProtXmlNamespace), IL2CPP.ManagedStringToIl2Cpp(value));
			}
		}

		// Token: 0x17000FB9 RID: 4025
		// (get) Token: 0x06003EA6 RID: 16038 RVA: 0x00124780 File Offset: 0x00122980
		// (set) Token: 0x06003EA7 RID: 16039 RVA: 0x000179E0 File Offset: 0x00015BE0
		public unsafe Object ReflectInfo
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapAttribute.NativeFieldInfoPtr_ReflectInfo);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SoapAttribute.NativeFieldInfoPtr_ReflectInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400338F RID: 13199
		private static readonly IntPtr NativeFieldInfoPtr__useAttribute;

		// Token: 0x04003390 RID: 13200
		private static readonly IntPtr NativeFieldInfoPtr_ProtXmlNamespace;

		// Token: 0x04003391 RID: 13201
		private static readonly IntPtr NativeFieldInfoPtr_ReflectInfo;

		// Token: 0x04003392 RID: 13202
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04003393 RID: 13203
		private static readonly IntPtr NativeMethodInfoPtr_get_UseAttribute_Public_Virtual_New_get_Boolean_0;

		// Token: 0x04003394 RID: 13204
		private static readonly IntPtr NativeMethodInfoPtr_get_XmlNamespace_Public_Virtual_New_get_String_0;

		// Token: 0x04003395 RID: 13205
		private static readonly IntPtr NativeMethodInfoPtr_SetReflectionObject_Internal_Virtual_New_Void_Object_0;
	}
}
