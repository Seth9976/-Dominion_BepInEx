using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Serialization;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000265 RID: 613
	[Serializable]
	public class AbandonedMutexException : SystemException
	{
		// Token: 0x06002A7C RID: 10876 RVA: 0x000DB420 File Offset: 0x000D9620
		// Note: this type is marked as 'beforefieldinit'.
		static AbandonedMutexException()
		{
			Il2CppClassPointerStore<AbandonedMutexException>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "AbandonedMutexException");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AbandonedMutexException>.NativeClassPtr);
			AbandonedMutexException.NativeFieldInfoPtr_m_MutexIndex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbandonedMutexException>.NativeClassPtr, "m_MutexIndex");
			AbandonedMutexException.NativeFieldInfoPtr_m_Mutex = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AbandonedMutexException>.NativeClassPtr, "m_Mutex");
			AbandonedMutexException.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbandonedMutexException>.NativeClassPtr, 100670055);
			AbandonedMutexException.NativeMethodInfoPtr__ctor_Public_Void_Int32_WaitHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbandonedMutexException>.NativeClassPtr, 100670056);
			AbandonedMutexException.NativeMethodInfoPtr_SetupException_Private_Void_Int32_WaitHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbandonedMutexException>.NativeClassPtr, 100670057);
			AbandonedMutexException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AbandonedMutexException>.NativeClassPtr, 100670058);
		}

		// Token: 0x06002A7D RID: 10877 RVA: 0x000DB4C8 File Offset: 0x000D96C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 331210, RefRangeEnd = 331211, XrefRangeStart = 331205, XrefRangeEnd = 331210, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AbandonedMutexException()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbandonedMutexException>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbandonedMutexException.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A7E RID: 10878 RVA: 0x000DB504 File Offset: 0x000D9704
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 331218, RefRangeEnd = 331219, XrefRangeStart = 331211, XrefRangeEnd = 331218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AbandonedMutexException(int location, WaitHandle handle)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbandonedMutexException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref location;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(handle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbandonedMutexException.NativeMethodInfoPtr__ctor_Public_Void_Int32_WaitHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A7F RID: 10879 RVA: 0x000DB560 File Offset: 0x000D9760
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331219, XrefRangeEnd = 331221, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetupException(int location, WaitHandle handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref location;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(handle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbandonedMutexException.NativeMethodInfoPtr_SetupException_Private_Void_Int32_WaitHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A80 RID: 10880 RVA: 0x000DB5B0 File Offset: 0x000D97B0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331221, XrefRangeEnd = 331222, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AbandonedMutexException(SerializationInfo info, StreamingContext context)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AbandonedMutexException>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(info);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(context));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AbandonedMutexException.NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A81 RID: 10881 RVA: 0x0000ECF5 File Offset: 0x0000CEF5
		public AbandonedMutexException(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A17 RID: 2583
		// (get) Token: 0x06002A82 RID: 10882 RVA: 0x000DB614 File Offset: 0x000D9814
		// (set) Token: 0x06002A83 RID: 10883 RVA: 0x0000ECFE File Offset: 0x0000CEFE
		public unsafe int m_MutexIndex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbandonedMutexException.NativeFieldInfoPtr_m_MutexIndex);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbandonedMutexException.NativeFieldInfoPtr_m_MutexIndex)) = value;
			}
		}

		// Token: 0x17000A18 RID: 2584
		// (get) Token: 0x06002A84 RID: 10884 RVA: 0x000DB63C File Offset: 0x000D983C
		// (set) Token: 0x06002A85 RID: 10885 RVA: 0x0000ED19 File Offset: 0x0000CF19
		public unsafe Mutex m_Mutex
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbandonedMutexException.NativeFieldInfoPtr_m_Mutex);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Mutex>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AbandonedMutexException.NativeFieldInfoPtr_m_Mutex), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400253D RID: 9533
		private static readonly IntPtr NativeFieldInfoPtr_m_MutexIndex;

		// Token: 0x0400253E RID: 9534
		private static readonly IntPtr NativeFieldInfoPtr_m_Mutex;

		// Token: 0x0400253F RID: 9535
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04002540 RID: 9536
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_WaitHandle_0;

		// Token: 0x04002541 RID: 9537
		private static readonly IntPtr NativeMethodInfoPtr_SetupException_Private_Void_Int32_WaitHandle_0;

		// Token: 0x04002542 RID: 9538
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_SerializationInfo_StreamingContext_0;
	}
}
