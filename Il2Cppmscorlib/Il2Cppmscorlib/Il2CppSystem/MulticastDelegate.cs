using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Reflection;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem
{
	// Token: 0x02000124 RID: 292
	[Serializable]
	public class MulticastDelegate : Delegate
	{
		// Token: 0x060014BE RID: 5310 RVA: 0x000808FC File Offset: 0x0007EAFC
		// Note: this type is marked as 'beforefieldinit'.
		static MulticastDelegate()
		{
			Il2CppClassPointerStore<MulticastDelegate>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "MulticastDelegate");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<MulticastDelegate>.NativeClassPtr);
			MulticastDelegate.NativeFieldInfoPtr_delegates = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<MulticastDelegate>.NativeClassPtr, "delegates");
			MulticastDelegate.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulticastDelegate>.NativeClassPtr, 100666834);
			MulticastDelegate.NativeMethodInfoPtr_Equals_Public_Virtual_Final_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulticastDelegate>.NativeClassPtr, 100666835);
			MulticastDelegate.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulticastDelegate>.NativeClassPtr, 100666836);
			MulticastDelegate.NativeMethodInfoPtr_GetMethodImpl_Protected_Virtual_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulticastDelegate>.NativeClassPtr, 100666837);
			MulticastDelegate.NativeMethodInfoPtr_GetInvocationList_Public_Virtual_Final_Il2CppReferenceArray_1_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulticastDelegate>.NativeClassPtr, 100666838);
			MulticastDelegate.NativeMethodInfoPtr_CombineImpl_Protected_Virtual_Final_Delegate_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulticastDelegate>.NativeClassPtr, 100666839);
			MulticastDelegate.NativeMethodInfoPtr_LastIndexOf_Private_Int32_Il2CppReferenceArray_1_Delegate_Il2CppReferenceArray_1_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulticastDelegate>.NativeClassPtr, 100666840);
			MulticastDelegate.NativeMethodInfoPtr_RemoveImpl_Protected_Virtual_Final_Delegate_Delegate_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<MulticastDelegate>.NativeClassPtr, 100666841);
		}

		// Token: 0x060014BF RID: 5311 RVA: 0x000809E0 File Offset: 0x0007EBE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306283, XrefRangeEnd = 306284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MulticastDelegate.NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060014C0 RID: 5312 RVA: 0x00080A44 File Offset: 0x0007EC44
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306284, XrefRangeEnd = 306287, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(obj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MulticastDelegate.NativeMethodInfoPtr_Equals_Public_Virtual_Final_Boolean_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060014C1 RID: 5313 RVA: 0x00080A94 File Offset: 0x0007EC94
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306287, XrefRangeEnd = 306288, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MulticastDelegate.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014C2 RID: 5314 RVA: 0x00080AD0 File Offset: 0x0007ECD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306288, XrefRangeEnd = 306293, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override MethodInfo GetMethodImpl()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), MulticastDelegate.NativeMethodInfoPtr_GetMethodImpl_Protected_Virtual_MethodInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<MethodInfo>(intPtr3) : null;
		}

		// Token: 0x060014C3 RID: 5315 RVA: 0x00080B1C File Offset: 0x0007ED1C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306293, XrefRangeEnd = 306297, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Il2CppReferenceArray<Delegate> GetInvocationList()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MulticastDelegate.NativeMethodInfoPtr_GetInvocationList_Public_Virtual_Final_Il2CppReferenceArray_1_Delegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Delegate>>(intPtr3) : null;
		}

		// Token: 0x060014C4 RID: 5316 RVA: 0x00080B5C File Offset: 0x0007ED5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306297, XrefRangeEnd = 306319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Delegate CombineImpl(Delegate follow)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(follow);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MulticastDelegate.NativeMethodInfoPtr_CombineImpl_Protected_Virtual_Final_Delegate_Delegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
			}
		}

		// Token: 0x060014C5 RID: 5317 RVA: 0x00080BAC File Offset: 0x0007EDAC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 306320, RefRangeEnd = 306321, XrefRangeStart = 306319, XrefRangeEnd = 306320, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe int LastIndexOf(Il2CppReferenceArray<Delegate> haystack, Il2CppReferenceArray<Delegate> needle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(haystack);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(needle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MulticastDelegate.NativeMethodInfoPtr_LastIndexOf_Private_Int32_Il2CppReferenceArray_1_Delegate_Il2CppReferenceArray_1_Delegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060014C6 RID: 5318 RVA: 0x00080C0C File Offset: 0x0007EE0C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 306321, XrefRangeEnd = 306343, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Delegate RemoveImpl(Delegate value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(MulticastDelegate.NativeMethodInfoPtr_RemoveImpl_Protected_Virtual_Final_Delegate_Delegate_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Delegate>(intPtr3) : null;
			}
		}

		// Token: 0x060014C7 RID: 5319 RVA: 0x00007414 File Offset: 0x00005614
		public MulticastDelegate(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x060014C8 RID: 5320 RVA: 0x00080C5C File Offset: 0x0007EE5C
		// (set) Token: 0x060014C9 RID: 5321 RVA: 0x0000741D File Offset: 0x0000561D
		public unsafe Il2CppReferenceArray<Delegate> delegates
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(MulticastDelegate.NativeFieldInfoPtr_delegates);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Delegate>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(MulticastDelegate.NativeFieldInfoPtr_delegates), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x040011AB RID: 4523
		private static readonly IntPtr NativeFieldInfoPtr_delegates;

		// Token: 0x040011AC RID: 4524
		private static readonly IntPtr NativeMethodInfoPtr_GetObjectData_Public_Virtual_Void_SerializationInfo_StreamingContext_0;

		// Token: 0x040011AD RID: 4525
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_Boolean_Object_0;

		// Token: 0x040011AE RID: 4526
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Final_Int32_0;

		// Token: 0x040011AF RID: 4527
		private static readonly IntPtr NativeMethodInfoPtr_GetMethodImpl_Protected_Virtual_MethodInfo_0;

		// Token: 0x040011B0 RID: 4528
		private static readonly IntPtr NativeMethodInfoPtr_GetInvocationList_Public_Virtual_Final_Il2CppReferenceArray_1_Delegate_0;

		// Token: 0x040011B1 RID: 4529
		private static readonly IntPtr NativeMethodInfoPtr_CombineImpl_Protected_Virtual_Final_Delegate_Delegate_0;

		// Token: 0x040011B2 RID: 4530
		private static readonly IntPtr NativeMethodInfoPtr_LastIndexOf_Private_Int32_Il2CppReferenceArray_1_Delegate_Il2CppReferenceArray_1_Delegate_0;

		// Token: 0x040011B3 RID: 4531
		private static readonly IntPtr NativeMethodInfoPtr_RemoveImpl_Protected_Virtual_Final_Delegate_Delegate_0;
	}
}
