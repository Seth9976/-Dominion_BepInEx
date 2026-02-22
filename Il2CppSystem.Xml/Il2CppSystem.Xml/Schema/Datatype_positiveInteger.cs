using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Xml.Schema
{
	// Token: 0x020000C4 RID: 196
	public class Datatype_positiveInteger : Datatype_nonNegativeInteger
	{
		// Token: 0x06000C5F RID: 3167 RVA: 0x0003BC90 File Offset: 0x00039E90
		// Note: this type is marked as 'beforefieldinit'.
		static Datatype_positiveInteger()
		{
			Il2CppClassPointerStore<Datatype_positiveInteger>.NativeClassPtr = IL2CPP.GetIl2CppClass("System.Xml.dll", "System.Xml.Schema", "Datatype_positiveInteger");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Datatype_positiveInteger>.NativeClassPtr);
			Datatype_positiveInteger.NativeFieldInfoPtr_numeric10FacetsChecker = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Datatype_positiveInteger>.NativeClassPtr, "numeric10FacetsChecker");
			Datatype_positiveInteger.NativeMethodInfoPtr_get_FacetsChecker_Internal_Virtual_get_FacetsChecker_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_positiveInteger>.NativeClassPtr, 100665119);
			Datatype_positiveInteger.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_positiveInteger>.NativeClassPtr, 100665120);
			Datatype_positiveInteger.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Datatype_positiveInteger>.NativeClassPtr, 100665121);
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x06000C60 RID: 3168 RVA: 0x0003BD10 File Offset: 0x00039F10
		public unsafe override FacetsChecker FacetsChecker
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23392, XrefRangeEnd = 23396, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_positiveInteger.NativeMethodInfoPtr_get_FacetsChecker_Internal_Virtual_get_FacetsChecker_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<FacetsChecker>(intPtr3) : null;
			}
		}

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x06000C61 RID: 3169 RVA: 0x0003BD5C File Offset: 0x00039F5C
		public unsafe override XmlTypeCode TypeCode
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Datatype_positiveInteger.NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06000C62 RID: 3170 RVA: 0x0003BDA4 File Offset: 0x00039FA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 23396, XrefRangeEnd = 23403, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Datatype_positiveInteger()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Datatype_positiveInteger>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Datatype_positiveInteger.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000C63 RID: 3171 RVA: 0x000061D6 File Offset: 0x000043D6
		public Datatype_positiveInteger(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x06000C64 RID: 3172 RVA: 0x0003BDE0 File Offset: 0x00039FE0
		// (set) Token: 0x06000C65 RID: 3173 RVA: 0x000061DF File Offset: 0x000043DF
		public new unsafe static FacetsChecker numeric10FacetsChecker
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Datatype_positiveInteger.NativeFieldInfoPtr_numeric10FacetsChecker, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<FacetsChecker>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Datatype_positiveInteger.NativeFieldInfoPtr_numeric10FacetsChecker, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000931 RID: 2353
		private static readonly IntPtr NativeFieldInfoPtr_numeric10FacetsChecker;

		// Token: 0x04000932 RID: 2354
		private static readonly IntPtr NativeMethodInfoPtr_get_FacetsChecker_Internal_Virtual_get_FacetsChecker_0;

		// Token: 0x04000933 RID: 2355
		private static readonly IntPtr NativeMethodInfoPtr_get_TypeCode_Public_Virtual_get_XmlTypeCode_0;

		// Token: 0x04000934 RID: 2356
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
