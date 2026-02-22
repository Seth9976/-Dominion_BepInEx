using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020000B9 RID: 185
	public class Datatype_nonPositiveInteger : Datatype_integer
	{
		// Token: 0x06000BD2 RID: 3026 RVA: 0x000398E8 File Offset: 0x00037AE8
		// Note: this type is marked as 'beforefieldinit'.
		static Datatype_nonPositiveInteger()
		{
			Il2CppClassPointerStore<Datatype_nonPositiveInteger>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "Datatype_nonPositiveInteger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Datatype_nonPositiveInteger>.NativeClassPtr);
			Datatype_nonPositiveInteger.NativeFieldInfoPtr_numeric10FacetsChecker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Datatype_nonPositiveInteger>.NativeClassPtr, "numeric10FacetsChecker");
			Datatype_nonPositiveInteger.NativeMethodInfoPtr_get_FacetsChecker_Internal_Virtual_get_FacetsChecker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_nonPositiveInteger>.NativeClassPtr, 100665043);
			Datatype_nonPositiveInteger.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_nonPositiveInteger>.NativeClassPtr, 100665044);
			Datatype_nonPositiveInteger.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_nonPositiveInteger>.NativeClassPtr, 100665045);
		}

		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x06000BD3 RID: 3027 RVA: 0x00039968 File Offset: 0x00037B68
		public unsafe override FacetsChecker FacetsChecker
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23084, XrefRangeEnd = 23088, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_nonPositiveInteger.NativeMethodInfoPtr_get_FacetsChecker_Internal_Virtual_get_FacetsChecker_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FacetsChecker>(intPtr3) : null;
			}
		}

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x06000BD4 RID: 3028 RVA: 0x000399B4 File Offset: 0x00037BB4
		public unsafe override XmlTypeCode TypeCode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_nonPositiveInteger.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000BD5 RID: 3029 RVA: 0x000399FC File Offset: 0x00037BFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Datatype_nonPositiveInteger()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Datatype_nonPositiveInteger>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Datatype_nonPositiveInteger.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000BD6 RID: 3030 RVA: 0x00005F8D File Offset: 0x0000418D
		public Datatype_nonPositiveInteger(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x06000BD7 RID: 3031 RVA: 0x00039A38 File Offset: 0x00037C38
		// (set) Token: 0x06000BD8 RID: 3032 RVA: 0x00005F96 File Offset: 0x00004196
		public new unsafe static FacetsChecker numeric10FacetsChecker
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Datatype_nonPositiveInteger.NativeFieldInfoPtr_numeric10FacetsChecker, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FacetsChecker>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Datatype_nonPositiveInteger.NativeFieldInfoPtr_numeric10FacetsChecker, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040008D5 RID: 2261
		private static readonly IntPtr NativeFieldInfoPtr_numeric10FacetsChecker;

		// Token: 0x040008D6 RID: 2262
		private static readonly IntPtr NativeMethodInfoPtr_get_FacetsChecker_Internal_Virtual_get_FacetsChecker_0;

		// Token: 0x040008D7 RID: 2263
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0;

		// Token: 0x040008D8 RID: 2264
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
