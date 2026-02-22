using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;

namespace Il2CppSystem
{
	// Token: 0x0200005F RID: 95
	[Serializable]
	public class __Filters : Object
	{
		// Token: 0x06000656 RID: 1622 RVA: 0x0003ECFC File Offset: 0x0003CEFC
		// Note: this type is marked as 'beforefieldinit'.
		static __Filters()
		{
			Il2CppClassPointerStore<__Filters>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "__Filters");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<__Filters>.NativeClassPtr);
			__Filters.NativeFieldInfoPtr_Instance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<__Filters>.NativeClassPtr, "Instance");
			__Filters.NativeMethodInfoPtr_FilterAttribute_Internal_Virtual_New_Boolean_MemberInfo_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__Filters>.NativeClassPtr, 100664318);
			__Filters.NativeMethodInfoPtr_FilterName_Internal_Virtual_New_Boolean_MemberInfo_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__Filters>.NativeClassPtr, 100664319);
			__Filters.NativeMethodInfoPtr_FilterIgnoreCase_Internal_Virtual_New_Boolean_MemberInfo_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__Filters>.NativeClassPtr, 100664320);
			__Filters.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<__Filters>.NativeClassPtr, 100664321);
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x0003ED90 File Offset: 0x0003CF90
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275293, XrefRangeEnd = 275300, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool FilterAttribute(MemberInfo m, Object filterCriteria)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(filterCriteria);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), __Filters.NativeMethodInfoPtr_FilterAttribute_Internal_Virtual_New_Boolean_MemberInfo_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x0003EDFC File Offset: 0x0003CFFC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275300, XrefRangeEnd = 275323, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool FilterName(MemberInfo m, Object filterCriteria)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(filterCriteria);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), __Filters.NativeMethodInfoPtr_FilterName_Internal_Virtual_New_Boolean_MemberInfo_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000659 RID: 1625 RVA: 0x0003EE68 File Offset: 0x0003D068
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 275323, XrefRangeEnd = 275331, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool FilterIgnoreCase(MemberInfo m, Object filterCriteria)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(m);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(filterCriteria);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), __Filters.NativeMethodInfoPtr_FilterIgnoreCase_Internal_Virtual_New_Boolean_MemberInfo_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x0003EED4 File Offset: 0x0003D0D4
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe __Filters()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<__Filters>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(__Filters.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x00004034 File Offset: 0x00002234
		public __Filters(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x0600065C RID: 1628 RVA: 0x0003EF10 File Offset: 0x0003D110
		// (set) Token: 0x0600065D RID: 1629 RVA: 0x0000403D File Offset: 0x0000223D
		public unsafe static __Filters Instance
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(__Filters.NativeFieldInfoPtr_Instance, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<__Filters>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(__Filters.NativeFieldInfoPtr_Instance, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040004B6 RID: 1206
		private static readonly IntPtr NativeFieldInfoPtr_Instance;

		// Token: 0x040004B7 RID: 1207
		private static readonly IntPtr NativeMethodInfoPtr_FilterAttribute_Internal_Virtual_New_Boolean_MemberInfo_Object_0;

		// Token: 0x040004B8 RID: 1208
		private static readonly IntPtr NativeMethodInfoPtr_FilterName_Internal_Virtual_New_Boolean_MemberInfo_Object_0;

		// Token: 0x040004B9 RID: 1209
		private static readonly IntPtr NativeMethodInfoPtr_FilterIgnoreCase_Internal_Virtual_New_Boolean_MemberInfo_Object_0;

		// Token: 0x040004BA RID: 1210
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
