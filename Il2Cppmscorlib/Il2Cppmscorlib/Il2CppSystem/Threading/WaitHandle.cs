using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppMicrosoft.Win32.SafeHandles;
using Il2CppSystem.Runtime.InteropServices;

namespace Il2CppSystem.Threading
{
	// Token: 0x0200028A RID: 650
	public class WaitHandle : MarshalByRefObject
	{
		// Token: 0x06002C1A RID: 11290 RVA: 0x000E132C File Offset: 0x000DF52C
		// Note: this type is marked as 'beforefieldinit'.
		static WaitHandle()
		{
			Il2CppClassPointerStore<WaitHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "WaitHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr);
			WaitHandle.NativeFieldInfoPtr_WaitTimeout = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, "WaitTimeout");
			WaitHandle.NativeFieldInfoPtr_MAX_WAITHANDLES = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, "MAX_WAITHANDLES");
			WaitHandle.NativeFieldInfoPtr_waitHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, "waitHandle");
			WaitHandle.NativeFieldInfoPtr_safeWaitHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, "safeWaitHandle");
			WaitHandle.NativeFieldInfoPtr_hasThreadAffinity = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, "hasThreadAffinity");
			WaitHandle.NativeFieldInfoPtr_WAIT_OBJECT_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, "WAIT_OBJECT_0");
			WaitHandle.NativeFieldInfoPtr_WAIT_ABANDONED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, "WAIT_ABANDONED");
			WaitHandle.NativeFieldInfoPtr_WAIT_FAILED = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, "WAIT_FAILED");
			WaitHandle.NativeFieldInfoPtr_ERROR_TOO_MANY_POSTS = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, "ERROR_TOO_MANY_POSTS");
			WaitHandle.NativeFieldInfoPtr_InvalidHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, "InvalidHandle");
			WaitHandle.NativeFieldInfoPtr_MaxWaitHandles = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, "MaxWaitHandles");
			WaitHandle.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, 100670306);
			WaitHandle.NativeMethodInfoPtr_Init_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, 100670307);
			WaitHandle.NativeMethodInfoPtr_set_Handle_Public_Virtual_New_set_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, 100670308);
			WaitHandle.NativeMethodInfoPtr_get_SafeWaitHandle_Public_get_SafeWaitHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, 100670309);
			WaitHandle.NativeMethodInfoPtr_SetHandleInternal_Internal_Void_SafeWaitHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, 100670310);
			WaitHandle.NativeMethodInfoPtr_WaitOne_Public_Virtual_New_Boolean_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, 100670311);
			WaitHandle.NativeMethodInfoPtr_WaitOne_Public_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, 100670312);
			WaitHandle.NativeMethodInfoPtr_WaitOne_Public_Virtual_New_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, 100670313);
			WaitHandle.NativeMethodInfoPtr_WaitOne_Private_Boolean_Int64_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, 100670314);
			WaitHandle.NativeMethodInfoPtr_InternalWaitOne_Internal_Static_Boolean_SafeHandle_Int64_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, 100670315);
			WaitHandle.NativeMethodInfoPtr_WaitAny_Public_Static_Int32_Il2CppReferenceArray_1_WaitHandle_Int32_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, 100670316);
			WaitHandle.NativeMethodInfoPtr_WaitAny_Public_Static_Int32_Il2CppReferenceArray_1_WaitHandle_TimeSpan_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, 100670317);
			WaitHandle.NativeMethodInfoPtr_ThrowAbandonedMutexException_Private_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, 100670318);
			WaitHandle.NativeMethodInfoPtr_ThrowAbandonedMutexException_Private_Static_Void_Int32_WaitHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, 100670319);
			WaitHandle.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, 100670320);
			WaitHandle.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, 100670321);
			WaitHandle.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, 100670322);
			WaitHandle.NativeMethodInfoPtr_WaitMultiple_Private_Static_Int32_Il2CppReferenceArray_1_WaitHandle_Int32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, 100670323);
			WaitHandle.NativeMethodInfoPtr_WaitOneNative_Private_Static_Int32_SafeHandle_UInt32_Boolean_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, 100670324);
			WaitHandle.NativeMethodInfoPtr_Wait_internal_Private_Static_Int32_ptr_IntPtr_Int32_Boolean_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr, 100670325);
		}

		// Token: 0x06002C1B RID: 11291 RVA: 0x000E15C8 File Offset: 0x000DF7C8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 333439, RefRangeEnd = 333440, XrefRangeStart = 333433, XrefRangeEnd = 333439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe WaitHandle()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<WaitHandle>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitHandle.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C1C RID: 11292 RVA: 0x000E1604 File Offset: 0x000DF804
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 333440, XrefRangeEnd = 333445, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Init()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitHandle.NativeMethodInfoPtr_Init_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17000A77 RID: 2679
		// (set) Token: 0x06002C1D RID: 11293 RVA: 0x000E1638 File Offset: 0x000DF838
		public unsafe virtual IntPtr Handle
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 333445, XrefRangeEnd = 333455, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaitHandle.NativeMethodInfoPtr_set_Handle_Public_Virtual_New_set_Void_IntPtr_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x17000A78 RID: 2680
		// (get) Token: 0x06002C1E RID: 11294 RVA: 0x000E1684 File Offset: 0x000DF884
		public unsafe SafeWaitHandle SafeWaitHandle
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 333467, RefRangeEnd = 333474, XrefRangeStart = 333455, XrefRangeEnd = 333467, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitHandle.NativeMethodInfoPtr_get_SafeWaitHandle_Public_get_SafeWaitHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SafeWaitHandle>(intPtr3) : null;
			}
		}

		// Token: 0x06002C1F RID: 11295 RVA: 0x000E16C4 File Offset: 0x000DF8C4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 333475, RefRangeEnd = 333476, XrefRangeStart = 333474, XrefRangeEnd = 333475, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHandleInternal(SafeWaitHandle handle)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(handle);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitHandle.NativeMethodInfoPtr_SetHandleInternal_Internal_Void_SafeWaitHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002C20 RID: 11296 RVA: 0x000E1708 File Offset: 0x000DF908
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 333476, XrefRangeEnd = 333485, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual bool WaitOne(int millisecondsTimeout, bool exitContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref millisecondsTimeout;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref exitContext;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaitHandle.NativeMethodInfoPtr_WaitOne_Public_Virtual_New_Boolean_Int32_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002C21 RID: 11297 RVA: 0x000E176C File Offset: 0x000DF96C
		[CallerCount(0)]
		public unsafe virtual bool WaitOne()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaitHandle.NativeMethodInfoPtr_WaitOne_Public_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002C22 RID: 11298 RVA: 0x000E17B4 File Offset: 0x000DF9B4
		[CallerCount(0)]
		public unsafe virtual bool WaitOne(int millisecondsTimeout)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref millisecondsTimeout;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaitHandle.NativeMethodInfoPtr_WaitOne_Public_Virtual_New_Boolean_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002C23 RID: 11299 RVA: 0x000E1808 File Offset: 0x000DFA08
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 333485, XrefRangeEnd = 333494, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool WaitOne(long timeout, bool exitContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref timeout;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref exitContext;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitHandle.NativeMethodInfoPtr_WaitOne_Private_Boolean_Int64_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002C24 RID: 11300 RVA: 0x000E1860 File Offset: 0x000DFA60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 333494, XrefRangeEnd = 333498, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool InternalWaitOne(SafeHandle waitableSafeHandle, long millisecondsTimeout, bool hasThreadAffinity, bool exitContext)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(waitableSafeHandle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref millisecondsTimeout;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasThreadAffinity;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref exitContext;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitHandle.NativeMethodInfoPtr_InternalWaitOne_Internal_Static_Boolean_SafeHandle_Int64_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002C25 RID: 11301 RVA: 0x000E18CC File Offset: 0x000DFACC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 333512, RefRangeEnd = 333513, XrefRangeStart = 333498, XrefRangeEnd = 333512, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int WaitAny(Il2CppReferenceArray<WaitHandle> waitHandles, int millisecondsTimeout, bool exitContext)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(waitHandles);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref millisecondsTimeout;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref exitContext;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitHandle.NativeMethodInfoPtr_WaitAny_Public_Static_Int32_Il2CppReferenceArray_1_WaitHandle_Int32_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002C26 RID: 11302 RVA: 0x000E192C File Offset: 0x000DFB2C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 333518, RefRangeEnd = 333519, XrefRangeStart = 333513, XrefRangeEnd = 333518, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int WaitAny(Il2CppReferenceArray<WaitHandle> waitHandles, TimeSpan timeout, bool exitContext)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(waitHandles);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref timeout;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref exitContext;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitHandle.NativeMethodInfoPtr_WaitAny_Public_Static_Int32_Il2CppReferenceArray_1_WaitHandle_TimeSpan_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002C27 RID: 11303 RVA: 0x000E198C File Offset: 0x000DFB8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 333519, XrefRangeEnd = 333524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowAbandonedMutexException()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitHandle.NativeMethodInfoPtr_ThrowAbandonedMutexException_Private_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C28 RID: 11304 RVA: 0x000E19B4 File Offset: 0x000DFBB4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 333524, XrefRangeEnd = 333529, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void ThrowAbandonedMutexException(int location, WaitHandle handle)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref location;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(handle);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitHandle.NativeMethodInfoPtr_ThrowAbandonedMutexException_Private_Static_Void_Int32_WaitHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C29 RID: 11305 RVA: 0x000E19F8 File Offset: 0x000DFBF8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 333529, XrefRangeEnd = 333533, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaitHandle.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C2A RID: 11306 RVA: 0x000E1A34 File Offset: 0x000DFC34
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 333533, XrefRangeEnd = 333536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool explicitDisposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref explicitDisposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), WaitHandle.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002C2B RID: 11307 RVA: 0x000E1A80 File Offset: 0x000DFC80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 333536, XrefRangeEnd = 333540, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitHandle.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002C2C RID: 11308 RVA: 0x000E1AB4 File Offset: 0x000DFCB4
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 333555, RefRangeEnd = 333556, XrefRangeStart = 333540, XrefRangeEnd = 333555, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int WaitMultiple(Il2CppReferenceArray<WaitHandle> waitHandles, int millisecondsTimeout, bool exitContext, bool WaitAll)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(waitHandles);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref millisecondsTimeout;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref exitContext;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref WaitAll;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitHandle.NativeMethodInfoPtr_WaitMultiple_Private_Static_Int32_Il2CppReferenceArray_1_WaitHandle_Int32_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002C2D RID: 11309 RVA: 0x000E1B20 File Offset: 0x000DFD20
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 333563, RefRangeEnd = 333566, XrefRangeStart = 333556, XrefRangeEnd = 333563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int WaitOneNative(SafeHandle waitableSafeHandle, uint millisecondsTimeout, bool hasThreadAffinity, bool exitContext)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(waitableSafeHandle);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref millisecondsTimeout;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref hasThreadAffinity;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref exitContext;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitHandle.NativeMethodInfoPtr_WaitOneNative_Private_Static_Int32_SafeHandle_UInt32_Boolean_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002C2E RID: 11310 RVA: 0x000E1B8C File Offset: 0x000DFD8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 333566, XrefRangeEnd = 333570, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int Wait_internal(IntPtr* handles, int numHandles, bool waitAll, int ms)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = handles;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref numHandles;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref waitAll;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref ms;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(WaitHandle.NativeMethodInfoPtr_Wait_internal_Private_Static_Int32_ptr_IntPtr_Int32_Boolean_Int32_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002C2F RID: 11311 RVA: 0x0000F5E7 File Offset: 0x0000D7E7
		public WaitHandle(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A6C RID: 2668
		// (get) Token: 0x06002C30 RID: 11312 RVA: 0x000E1BF4 File Offset: 0x000DFDF4
		// (set) Token: 0x06002C31 RID: 11313 RVA: 0x0000F5F0 File Offset: 0x0000D7F0
		public unsafe static int WaitTimeout
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WaitHandle.NativeFieldInfoPtr_WaitTimeout, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WaitHandle.NativeFieldInfoPtr_WaitTimeout, (void*)(&value));
			}
		}

		// Token: 0x17000A6D RID: 2669
		// (get) Token: 0x06002C32 RID: 11314 RVA: 0x000E1C10 File Offset: 0x000DFE10
		// (set) Token: 0x06002C33 RID: 11315 RVA: 0x0000F5FE File Offset: 0x0000D7FE
		public unsafe static int MAX_WAITHANDLES
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WaitHandle.NativeFieldInfoPtr_MAX_WAITHANDLES, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WaitHandle.NativeFieldInfoPtr_MAX_WAITHANDLES, (void*)(&value));
			}
		}

		// Token: 0x17000A6E RID: 2670
		// (get) Token: 0x06002C34 RID: 11316 RVA: 0x000E1C2C File Offset: 0x000DFE2C
		// (set) Token: 0x06002C35 RID: 11317 RVA: 0x0000F60C File Offset: 0x0000D80C
		public unsafe IntPtr waitHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitHandle.NativeFieldInfoPtr_waitHandle);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitHandle.NativeFieldInfoPtr_waitHandle)) = value;
			}
		}

		// Token: 0x17000A6F RID: 2671
		// (get) Token: 0x06002C36 RID: 11318 RVA: 0x000E1C54 File Offset: 0x000DFE54
		// (set) Token: 0x06002C37 RID: 11319 RVA: 0x0000F627 File Offset: 0x0000D827
		public unsafe SafeWaitHandle safeWaitHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitHandle.NativeFieldInfoPtr_safeWaitHandle);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SafeWaitHandle>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitHandle.NativeFieldInfoPtr_safeWaitHandle), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000A70 RID: 2672
		// (get) Token: 0x06002C38 RID: 11320 RVA: 0x000E1C84 File Offset: 0x000DFE84
		// (set) Token: 0x06002C39 RID: 11321 RVA: 0x0000F646 File Offset: 0x0000D846
		public unsafe bool hasThreadAffinity
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitHandle.NativeFieldInfoPtr_hasThreadAffinity);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(WaitHandle.NativeFieldInfoPtr_hasThreadAffinity)) = value;
			}
		}

		// Token: 0x17000A71 RID: 2673
		// (get) Token: 0x06002C3A RID: 11322 RVA: 0x000E1CAC File Offset: 0x000DFEAC
		// (set) Token: 0x06002C3B RID: 11323 RVA: 0x0000F661 File Offset: 0x0000D861
		public unsafe static int WAIT_OBJECT_0
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WaitHandle.NativeFieldInfoPtr_WAIT_OBJECT_0, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WaitHandle.NativeFieldInfoPtr_WAIT_OBJECT_0, (void*)(&value));
			}
		}

		// Token: 0x17000A72 RID: 2674
		// (get) Token: 0x06002C3C RID: 11324 RVA: 0x000E1CC8 File Offset: 0x000DFEC8
		// (set) Token: 0x06002C3D RID: 11325 RVA: 0x0000F66F File Offset: 0x0000D86F
		public unsafe static int WAIT_ABANDONED
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WaitHandle.NativeFieldInfoPtr_WAIT_ABANDONED, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WaitHandle.NativeFieldInfoPtr_WAIT_ABANDONED, (void*)(&value));
			}
		}

		// Token: 0x17000A73 RID: 2675
		// (get) Token: 0x06002C3E RID: 11326 RVA: 0x000E1CE4 File Offset: 0x000DFEE4
		// (set) Token: 0x06002C3F RID: 11327 RVA: 0x0000F67D File Offset: 0x0000D87D
		public unsafe static int WAIT_FAILED
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WaitHandle.NativeFieldInfoPtr_WAIT_FAILED, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WaitHandle.NativeFieldInfoPtr_WAIT_FAILED, (void*)(&value));
			}
		}

		// Token: 0x17000A74 RID: 2676
		// (get) Token: 0x06002C40 RID: 11328 RVA: 0x000E1D00 File Offset: 0x000DFF00
		// (set) Token: 0x06002C41 RID: 11329 RVA: 0x0000F68B File Offset: 0x0000D88B
		public unsafe static int ERROR_TOO_MANY_POSTS
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WaitHandle.NativeFieldInfoPtr_ERROR_TOO_MANY_POSTS, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WaitHandle.NativeFieldInfoPtr_ERROR_TOO_MANY_POSTS, (void*)(&value));
			}
		}

		// Token: 0x17000A75 RID: 2677
		// (get) Token: 0x06002C42 RID: 11330 RVA: 0x000E1D1C File Offset: 0x000DFF1C
		// (set) Token: 0x06002C43 RID: 11331 RVA: 0x0000F699 File Offset: 0x0000D899
		public unsafe static IntPtr InvalidHandle
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(WaitHandle.NativeFieldInfoPtr_InvalidHandle, (void*)(&intPtr));
				return intPtr;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WaitHandle.NativeFieldInfoPtr_InvalidHandle, (void*)(&value));
			}
		}

		// Token: 0x17000A76 RID: 2678
		// (get) Token: 0x06002C44 RID: 11332 RVA: 0x000E1D38 File Offset: 0x000DFF38
		// (set) Token: 0x06002C45 RID: 11333 RVA: 0x0000F6A7 File Offset: 0x0000D8A7
		public unsafe static int MaxWaitHandles
		{
			get
			{
				int num;
				IL2CPP.il2cpp_field_static_get_value(WaitHandle.NativeFieldInfoPtr_MaxWaitHandles, (void*)(&num));
				return num;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(WaitHandle.NativeFieldInfoPtr_MaxWaitHandles, (void*)(&value));
			}
		}

		// Token: 0x0400265C RID: 9820
		private static readonly IntPtr NativeFieldInfoPtr_WaitTimeout;

		// Token: 0x0400265D RID: 9821
		private static readonly IntPtr NativeFieldInfoPtr_MAX_WAITHANDLES;

		// Token: 0x0400265E RID: 9822
		private static readonly IntPtr NativeFieldInfoPtr_waitHandle;

		// Token: 0x0400265F RID: 9823
		private static readonly IntPtr NativeFieldInfoPtr_safeWaitHandle;

		// Token: 0x04002660 RID: 9824
		private static readonly IntPtr NativeFieldInfoPtr_hasThreadAffinity;

		// Token: 0x04002661 RID: 9825
		private static readonly IntPtr NativeFieldInfoPtr_WAIT_OBJECT_0;

		// Token: 0x04002662 RID: 9826
		private static readonly IntPtr NativeFieldInfoPtr_WAIT_ABANDONED;

		// Token: 0x04002663 RID: 9827
		private static readonly IntPtr NativeFieldInfoPtr_WAIT_FAILED;

		// Token: 0x04002664 RID: 9828
		private static readonly IntPtr NativeFieldInfoPtr_ERROR_TOO_MANY_POSTS;

		// Token: 0x04002665 RID: 9829
		private static readonly IntPtr NativeFieldInfoPtr_InvalidHandle;

		// Token: 0x04002666 RID: 9830
		private static readonly IntPtr NativeFieldInfoPtr_MaxWaitHandles;

		// Token: 0x04002667 RID: 9831
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x04002668 RID: 9832
		private static readonly IntPtr NativeMethodInfoPtr_Init_Private_Void_0;

		// Token: 0x04002669 RID: 9833
		private static readonly IntPtr NativeMethodInfoPtr_set_Handle_Public_Virtual_New_set_Void_IntPtr_0;

		// Token: 0x0400266A RID: 9834
		private static readonly IntPtr NativeMethodInfoPtr_get_SafeWaitHandle_Public_get_SafeWaitHandle_0;

		// Token: 0x0400266B RID: 9835
		private static readonly IntPtr NativeMethodInfoPtr_SetHandleInternal_Internal_Void_SafeWaitHandle_0;

		// Token: 0x0400266C RID: 9836
		private static readonly IntPtr NativeMethodInfoPtr_WaitOne_Public_Virtual_New_Boolean_Int32_Boolean_0;

		// Token: 0x0400266D RID: 9837
		private static readonly IntPtr NativeMethodInfoPtr_WaitOne_Public_Virtual_New_Boolean_0;

		// Token: 0x0400266E RID: 9838
		private static readonly IntPtr NativeMethodInfoPtr_WaitOne_Public_Virtual_New_Boolean_Int32_0;

		// Token: 0x0400266F RID: 9839
		private static readonly IntPtr NativeMethodInfoPtr_WaitOne_Private_Boolean_Int64_Boolean_0;

		// Token: 0x04002670 RID: 9840
		private static readonly IntPtr NativeMethodInfoPtr_InternalWaitOne_Internal_Static_Boolean_SafeHandle_Int64_Boolean_Boolean_0;

		// Token: 0x04002671 RID: 9841
		private static readonly IntPtr NativeMethodInfoPtr_WaitAny_Public_Static_Int32_Il2CppReferenceArray_1_WaitHandle_Int32_Boolean_0;

		// Token: 0x04002672 RID: 9842
		private static readonly IntPtr NativeMethodInfoPtr_WaitAny_Public_Static_Int32_Il2CppReferenceArray_1_WaitHandle_TimeSpan_Boolean_0;

		// Token: 0x04002673 RID: 9843
		private static readonly IntPtr NativeMethodInfoPtr_ThrowAbandonedMutexException_Private_Static_Void_0;

		// Token: 0x04002674 RID: 9844
		private static readonly IntPtr NativeMethodInfoPtr_ThrowAbandonedMutexException_Private_Static_Void_Int32_WaitHandle_0;

		// Token: 0x04002675 RID: 9845
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0;

		// Token: 0x04002676 RID: 9846
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x04002677 RID: 9847
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04002678 RID: 9848
		private static readonly IntPtr NativeMethodInfoPtr_WaitMultiple_Private_Static_Int32_Il2CppReferenceArray_1_WaitHandle_Int32_Boolean_Boolean_0;

		// Token: 0x04002679 RID: 9849
		private static readonly IntPtr NativeMethodInfoPtr_WaitOneNative_Private_Static_Int32_SafeHandle_UInt32_Boolean_Boolean_0;

		// Token: 0x0400267A RID: 9850
		private static readonly IntPtr NativeMethodInfoPtr_Wait_internal_Private_Static_Int32_ptr_IntPtr_Int32_Boolean_Int32_0;
	}
}
