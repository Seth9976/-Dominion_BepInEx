using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Globalization;

namespace Il2CppSystem.Reflection
{
	// Token: 0x020001D2 RID: 466
	public class RtFieldInfo : RuntimeFieldInfo
	{
		// Token: 0x06001DEF RID: 7663 RVA: 0x000A7DEC File Offset: 0x000A5FEC
		// Note: this type is marked as 'beforefieldinit'.
		static RtFieldInfo()
		{
			Il2CppClassPointerStore<RtFieldInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Reflection", "RtFieldInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RtFieldInfo>.NativeClassPtr);
			RtFieldInfo.NativeMethodInfoPtr_UnsafeGetValue_Internal_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RtFieldInfo>.NativeClassPtr, 100668246);
			RtFieldInfo.NativeMethodInfoPtr_CheckConsistency_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RtFieldInfo>.NativeClassPtr, 100668247);
			RtFieldInfo.NativeMethodInfoPtr_UnsafeSetValue_Internal_Void_Object_Object_BindingFlags_Binder_CultureInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RtFieldInfo>.NativeClassPtr, 100668248);
			RtFieldInfo.NativeMethodInfoPtr_SetValueDirect_Public_Virtual_Void_TypedReference_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RtFieldInfo>.NativeClassPtr, 100668249);
			RtFieldInfo.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RtFieldInfo>.NativeClassPtr, 100668250);
		}

		// Token: 0x06001DF0 RID: 7664 RVA: 0x000A7E80 File Offset: 0x000A6080
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 318487, RefRangeEnd = 318492, XrefRangeStart = 318486, XrefRangeEnd = 318487, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Object UnsafeGetValue(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RtFieldInfo.NativeMethodInfoPtr_UnsafeGetValue_Internal_Object_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x06001DF1 RID: 7665 RVA: 0x000A7ED0 File Offset: 0x000A60D0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 318493, RefRangeEnd = 318496, XrefRangeStart = 318492, XrefRangeEnd = 318493, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void CheckConsistency(Object target)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RtFieldInfo.NativeMethodInfoPtr_CheckConsistency_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001DF2 RID: 7666 RVA: 0x000A7F14 File Offset: 0x000A6114
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 318497, RefRangeEnd = 318498, XrefRangeStart = 318496, XrefRangeEnd = 318497, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void UnsafeSetValue(Object obj, Object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref invokeAttr;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(binder);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(culture);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RtFieldInfo.NativeMethodInfoPtr_UnsafeSetValue_Internal_Void_Object_Object_BindingFlags_Binder_CultureInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DF3 RID: 7667 RVA: 0x000A7F9C File Offset: 0x000A619C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 318498, XrefRangeEnd = 318503, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void SetValueDirect(TypedReference obj, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref obj;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), RtFieldInfo.NativeMethodInfoPtr_SetValueDirect_Public_Virtual_Void_TypedReference_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DF4 RID: 7668 RVA: 0x000A7FF8 File Offset: 0x000A61F8
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 40944, RefRangeEnd = 40950, XrefRangeStart = 40944, XrefRangeEnd = 40950, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe RtFieldInfo()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<RtFieldInfo>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RtFieldInfo.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06001DF5 RID: 7669 RVA: 0x0000A558 File Offset: 0x00008758
		public RtFieldInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04001B4F RID: 6991
		private static readonly IntPtr NativeMethodInfoPtr_UnsafeGetValue_Internal_Object_Object_0;

		// Token: 0x04001B50 RID: 6992
		private static readonly IntPtr NativeMethodInfoPtr_CheckConsistency_Internal_Void_Object_0;

		// Token: 0x04001B51 RID: 6993
		private static readonly IntPtr NativeMethodInfoPtr_UnsafeSetValue_Internal_Void_Object_Object_BindingFlags_Binder_CultureInfo_0;

		// Token: 0x04001B52 RID: 6994
		private static readonly IntPtr NativeMethodInfoPtr_SetValueDirect_Public_Virtual_Void_TypedReference_Object_0;

		// Token: 0x04001B53 RID: 6995
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;
	}
}
