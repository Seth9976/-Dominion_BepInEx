using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000275 RID: 629
	public class SynchronizationContext : Object
	{
		// Token: 0x06002B20 RID: 11040 RVA: 0x000DDCEC File Offset: 0x000DBEEC
		// Note: this type is marked as 'beforefieldinit'.
		static SynchronizationContext()
		{
			Il2CppClassPointerStore<SynchronizationContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "SynchronizationContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SynchronizationContext>.NativeClassPtr);
			SynchronizationContext.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SynchronizationContext>.NativeClassPtr, 100670153);
			SynchronizationContext.NativeMethodInfoPtr_Send_Public_Virtual_New_Void_SendOrPostCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SynchronizationContext>.NativeClassPtr, 100670154);
			SynchronizationContext.NativeMethodInfoPtr_Post_Public_Virtual_New_Void_SendOrPostCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SynchronizationContext>.NativeClassPtr, 100670155);
			SynchronizationContext.NativeMethodInfoPtr_OperationStarted_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SynchronizationContext>.NativeClassPtr, 100670156);
			SynchronizationContext.NativeMethodInfoPtr_OperationCompleted_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SynchronizationContext>.NativeClassPtr, 100670157);
			SynchronizationContext.NativeMethodInfoPtr_SetSynchronizationContext_Public_Static_Void_SynchronizationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SynchronizationContext>.NativeClassPtr, 100670158);
			SynchronizationContext.NativeMethodInfoPtr_get_Current_Public_Static_get_SynchronizationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SynchronizationContext>.NativeClassPtr, 100670159);
			SynchronizationContext.NativeMethodInfoPtr_get_CurrentNoFlow_Internal_Static_get_SynchronizationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SynchronizationContext>.NativeClassPtr, 100670160);
			SynchronizationContext.NativeMethodInfoPtr_GetThreadLocalContext_Private_Static_SynchronizationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SynchronizationContext>.NativeClassPtr, 100670161);
			SynchronizationContext.NativeMethodInfoPtr_CreateCopy_Public_Virtual_New_SynchronizationContext_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SynchronizationContext>.NativeClassPtr, 100670162);
		}

		// Token: 0x06002B21 RID: 11041 RVA: 0x000DDDE4 File Offset: 0x000DBFE4
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SynchronizationContext()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SynchronizationContext>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SynchronizationContext.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B22 RID: 11042 RVA: 0x000DDE20 File Offset: 0x000DC020
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332328, XrefRangeEnd = 332330, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Send(SendOrPostCallback d, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SynchronizationContext.NativeMethodInfoPtr_Send_Public_Virtual_New_Void_SendOrPostCallback_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B23 RID: 11043 RVA: 0x000DDE80 File Offset: 0x000DC080
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332330, XrefRangeEnd = 332337, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Post(SendOrPostCallback d, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(d);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SynchronizationContext.NativeMethodInfoPtr_Post_Public_Virtual_New_Void_SendOrPostCallback_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B24 RID: 11044 RVA: 0x000DDEE0 File Offset: 0x000DC0E0
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OperationStarted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SynchronizationContext.NativeMethodInfoPtr_OperationStarted_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B25 RID: 11045 RVA: 0x000DDF1C File Offset: 0x000DC11C
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void OperationCompleted()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SynchronizationContext.NativeMethodInfoPtr_OperationCompleted_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002B26 RID: 11046 RVA: 0x000DDF58 File Offset: 0x000DC158
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 332339, RefRangeEnd = 332340, XrefRangeStart = 332337, XrefRangeEnd = 332339, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void SetSynchronizationContext(SynchronizationContext syncContext)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(syncContext);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SynchronizationContext.NativeMethodInfoPtr_SetSynchronizationContext_Public_Static_Void_SynchronizationContext_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000A35 RID: 2613
		// (get) Token: 0x06002B27 RID: 11047 RVA: 0x000DDF90 File Offset: 0x000DC190
		public unsafe static SynchronizationContext Current
		{
			[CallerCount(3)]
			[CachedScanResults(RefRangeStart = 332347, RefRangeEnd = 332350, XrefRangeStart = 332340, XrefRangeEnd = 332347, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SynchronizationContext.NativeMethodInfoPtr_get_Current_Public_Static_get_SynchronizationContext_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SynchronizationContext>(intPtr3) : null;
			}
		}

		// Token: 0x17000A36 RID: 2614
		// (get) Token: 0x06002B28 RID: 11048 RVA: 0x000DDFC4 File Offset: 0x000DC1C4
		public unsafe static SynchronizationContext CurrentNoFlow
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 332357, RefRangeEnd = 332361, XrefRangeStart = 332350, XrefRangeEnd = 332357, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SynchronizationContext.NativeMethodInfoPtr_get_CurrentNoFlow_Internal_Static_get_SynchronizationContext_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SynchronizationContext>(intPtr3) : null;
			}
		}

		// Token: 0x06002B29 RID: 11049 RVA: 0x000DDFF8 File Offset: 0x000DC1F8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332361, XrefRangeEnd = 332365, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static SynchronizationContext GetThreadLocalContext()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SynchronizationContext.NativeMethodInfoPtr_GetThreadLocalContext_Private_Static_SynchronizationContext_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SynchronizationContext>(intPtr3) : null;
		}

		// Token: 0x06002B2A RID: 11050 RVA: 0x000DE02C File Offset: 0x000DC22C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 332365, XrefRangeEnd = 332369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual SynchronizationContext CreateCopy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), SynchronizationContext.NativeMethodInfoPtr_CreateCopy_Public_Virtual_New_SynchronizationContext_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SynchronizationContext>(intPtr3) : null;
		}

		// Token: 0x06002B2B RID: 11051 RVA: 0x0000F098 File Offset: 0x0000D298
		public SynchronizationContext(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040025A9 RID: 9641
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x040025AA RID: 9642
		private static readonly IntPtr NativeMethodInfoPtr_Send_Public_Virtual_New_Void_SendOrPostCallback_Object_0;

		// Token: 0x040025AB RID: 9643
		private static readonly IntPtr NativeMethodInfoPtr_Post_Public_Virtual_New_Void_SendOrPostCallback_Object_0;

		// Token: 0x040025AC RID: 9644
		private static readonly IntPtr NativeMethodInfoPtr_OperationStarted_Public_Virtual_New_Void_0;

		// Token: 0x040025AD RID: 9645
		private static readonly IntPtr NativeMethodInfoPtr_OperationCompleted_Public_Virtual_New_Void_0;

		// Token: 0x040025AE RID: 9646
		private static readonly IntPtr NativeMethodInfoPtr_SetSynchronizationContext_Public_Static_Void_SynchronizationContext_0;

		// Token: 0x040025AF RID: 9647
		private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Static_get_SynchronizationContext_0;

		// Token: 0x040025B0 RID: 9648
		private static readonly IntPtr NativeMethodInfoPtr_get_CurrentNoFlow_Internal_Static_get_SynchronizationContext_0;

		// Token: 0x040025B1 RID: 9649
		private static readonly IntPtr NativeMethodInfoPtr_GetThreadLocalContext_Private_Static_SynchronizationContext_0;

		// Token: 0x040025B2 RID: 9650
		private static readonly IntPtr NativeMethodInfoPtr_CreateCopy_Public_Virtual_New_SynchronizationContext_0;
	}
}
