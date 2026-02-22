using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020000BF RID: 191
	public class Datatype_nonNegativeInteger : Datatype_integer
	{
		// Token: 0x06000C1C RID: 3100 RVA: 0x0003AB78 File Offset: 0x00038D78
		// Note: this type is marked as 'beforefieldinit'.
		static Datatype_nonNegativeInteger()
		{
			Il2CppClassPointerStore<Datatype_nonNegativeInteger>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "Datatype_nonNegativeInteger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Datatype_nonNegativeInteger>.NativeClassPtr);
			Datatype_nonNegativeInteger.NativeFieldInfoPtr_numeric10FacetsChecker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Datatype_nonNegativeInteger>.NativeClassPtr, "numeric10FacetsChecker");
			Datatype_nonNegativeInteger.NativeMethodInfoPtr_get_FacetsChecker_Internal_Virtual_get_FacetsChecker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_nonNegativeInteger>.NativeClassPtr, 100665083);
			Datatype_nonNegativeInteger.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_nonNegativeInteger>.NativeClassPtr, 100665084);
			Datatype_nonNegativeInteger.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_nonNegativeInteger>.NativeClassPtr, 100665085);
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x06000C1D RID: 3101 RVA: 0x0003ABF8 File Offset: 0x00038DF8
		public unsafe override FacetsChecker FacetsChecker
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23239, XrefRangeEnd = 23243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_nonNegativeInteger.NativeMethodInfoPtr_get_FacetsChecker_Internal_Virtual_get_FacetsChecker_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FacetsChecker>(intPtr3) : null;
			}
		}

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x06000C1E RID: 3102 RVA: 0x0003AC44 File Offset: 0x00038E44
		public unsafe override XmlTypeCode TypeCode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_nonNegativeInteger.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C1F RID: 3103 RVA: 0x0003AC8C File Offset: 0x00038E8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Datatype_nonNegativeInteger()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Datatype_nonNegativeInteger>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Datatype_nonNegativeInteger.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C20 RID: 3104 RVA: 0x000060BF File Offset: 0x000042BF
		public Datatype_nonNegativeInteger(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000476 RID: 1142
		// (get) Token: 0x06000C21 RID: 3105 RVA: 0x0003ACC8 File Offset: 0x00038EC8
		// (set) Token: 0x06000C22 RID: 3106 RVA: 0x000060C8 File Offset: 0x000042C8
		public new unsafe static FacetsChecker numeric10FacetsChecker
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Datatype_nonNegativeInteger.NativeFieldInfoPtr_numeric10FacetsChecker, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FacetsChecker>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Datatype_nonNegativeInteger.NativeFieldInfoPtr_numeric10FacetsChecker, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000905 RID: 2309
		private static readonly IntPtr NativeFieldInfoPtr_numeric10FacetsChecker;

		// Token: 0x04000906 RID: 2310
		private static readonly IntPtr NativeMethodInfoPtr_get_FacetsChecker_Internal_Virtual_get_FacetsChecker_0;

		// Token: 0x04000907 RID: 2311
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0;

		// Token: 0x04000908 RID: 2312
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
