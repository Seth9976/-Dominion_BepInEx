using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020000BA RID: 186
	public class Datatype_negativeInteger : Datatype_nonPositiveInteger
	{
		// Token: 0x06000BD9 RID: 3033 RVA: 0x00039A60 File Offset: 0x00037C60
		// Note: this type is marked as 'beforefieldinit'.
		static Datatype_negativeInteger()
		{
			Il2CppClassPointerStore<Datatype_negativeInteger>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "Datatype_negativeInteger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Datatype_negativeInteger>.NativeClassPtr);
			Datatype_negativeInteger.NativeFieldInfoPtr_numeric10FacetsChecker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Datatype_negativeInteger>.NativeClassPtr, "numeric10FacetsChecker");
			Datatype_negativeInteger.NativeMethodInfoPtr_get_FacetsChecker_Internal_Virtual_get_FacetsChecker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_negativeInteger>.NativeClassPtr, 100665047);
			Datatype_negativeInteger.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_negativeInteger>.NativeClassPtr, 100665048);
			Datatype_negativeInteger.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_negativeInteger>.NativeClassPtr, 100665049);
		}

		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x06000BDA RID: 3034 RVA: 0x00039AE0 File Offset: 0x00037CE0
		public unsafe override FacetsChecker FacetsChecker
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23088, XrefRangeEnd = 23092, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_negativeInteger.NativeMethodInfoPtr_get_FacetsChecker_Internal_Virtual_get_FacetsChecker_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FacetsChecker>(intPtr3) : null;
			}
		}

		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x06000BDB RID: 3035 RVA: 0x00039B2C File Offset: 0x00037D2C
		public unsafe override XmlTypeCode TypeCode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_negativeInteger.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BDC RID: 3036 RVA: 0x00039B74 File Offset: 0x00037D74
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23092, XrefRangeEnd = 23099, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Datatype_negativeInteger()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Datatype_negativeInteger>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Datatype_negativeInteger.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BDD RID: 3037 RVA: 0x00005FA8 File Offset: 0x000041A8
		public Datatype_negativeInteger(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x06000BDE RID: 3038 RVA: 0x00039BB0 File Offset: 0x00037DB0
		// (set) Token: 0x06000BDF RID: 3039 RVA: 0x00005FB1 File Offset: 0x000041B1
		public new unsafe static FacetsChecker numeric10FacetsChecker
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Datatype_negativeInteger.NativeFieldInfoPtr_numeric10FacetsChecker, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FacetsChecker>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Datatype_negativeInteger.NativeFieldInfoPtr_numeric10FacetsChecker, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040008D9 RID: 2265
		private static readonly IntPtr NativeFieldInfoPtr_numeric10FacetsChecker;

		// Token: 0x040008DA RID: 2266
		private static readonly IntPtr NativeMethodInfoPtr_get_FacetsChecker_Internal_Virtual_get_FacetsChecker_0;

		// Token: 0x040008DB RID: 2267
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0;

		// Token: 0x040008DC RID: 2268
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
