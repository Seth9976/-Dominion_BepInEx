using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.ExceptionServices;
using Il2CppSystem.Threading;
using Il2CppSystem.Threading.Tasks;

namespace Il2CppSystem.IO
{
	// Token: 0x0200020A RID: 522
	[Serializable]
	public class Stream : MarshalByRefObject
	{
		// Token: 0x06002165 RID: 8549 RVA: 0x000B82B0 File Offset: 0x000B64B0
		// Note: this type is marked as 'beforefieldinit'.
		static Stream()
		{
			Il2CppClassPointerStore<Stream>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "Stream");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Stream>.NativeClassPtr);
			Stream.NativeFieldInfoPtr_Null = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream>.NativeClassPtr, "Null");
			Stream.NativeFieldInfoPtr__activeReadWriteTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream>.NativeClassPtr, "_activeReadWriteTask");
			Stream.NativeFieldInfoPtr__asyncActiveSemaphore = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream>.NativeClassPtr, "_asyncActiveSemaphore");
			Stream.NativeMethodInfoPtr_EnsureAsyncActiveSemaphoreInitialized_Internal_SemaphoreSlim_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100668819);
			Stream.NativeMethodInfoPtr_get_CanRead_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100668820);
			Stream.NativeMethodInfoPtr_get_CanSeek_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100668821);
			Stream.NativeMethodInfoPtr_get_CanWrite_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100668822);
			Stream.NativeMethodInfoPtr_get_Length_Public_Abstract_Virtual_New_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100668823);
			Stream.NativeMethodInfoPtr_get_Position_Public_Abstract_Virtual_New_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100668824);
			Stream.NativeMethodInfoPtr_set_Position_Public_Abstract_Virtual_New_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100668825);
			Stream.NativeMethodInfoPtr_get_ReadTimeout_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100668826);
			Stream.NativeMethodInfoPtr_set_ReadTimeout_Public_Virtual_New_set_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100668827);
			Stream.NativeMethodInfoPtr_get_WriteTimeout_Public_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100668828);
			Stream.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100668829);
			Stream.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100668830);
			Stream.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100668831);
			Stream.NativeMethodInfoPtr_Flush_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100668832);
			Stream.NativeMethodInfoPtr_BeginRead_Public_Virtual_New_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100668833);
			Stream.NativeMethodInfoPtr_BeginReadInternal_Internal_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100668834);
			Stream.NativeMethodInfoPtr_EndRead_Public_Virtual_New_Int32_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100668835);
			Stream.NativeMethodInfoPtr_ReadAsync_Public_Virtual_New_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100668836);
			Stream.NativeMethodInfoPtr_BeginEndReadAsync_Private_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100668837);
			Stream.NativeMethodInfoPtr_BeginWrite_Public_Virtual_New_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100668838);
			Stream.NativeMethodInfoPtr_BeginWriteInternal_Internal_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100668839);
			Stream.NativeMethodInfoPtr_RunReadWriteTaskWhenReady_Private_Void_Task_ReadWriteTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100668840);
			Stream.NativeMethodInfoPtr_RunReadWriteTask_Private_Void_ReadWriteTask_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100668841);
			Stream.NativeMethodInfoPtr_EndWrite_Public_Virtual_New_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100668842);
			Stream.NativeMethodInfoPtr_WriteAsync_Public_Task_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100668843);
			Stream.NativeMethodInfoPtr_WriteAsync_Public_Virtual_New_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100668844);
			Stream.NativeMethodInfoPtr_BeginEndWriteAsync_Private_Task_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100668845);
			Stream.NativeMethodInfoPtr_Seek_Public_Abstract_Virtual_New_Int64_Int64_SeekOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100668846);
			Stream.NativeMethodInfoPtr_Read_Public_Abstract_Virtual_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100668847);
			Stream.NativeMethodInfoPtr_ReadByte_Public_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100668848);
			Stream.NativeMethodInfoPtr_Write_Public_Abstract_Virtual_New_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100668849);
			Stream.NativeMethodInfoPtr_WriteByte_Public_Virtual_New_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100668850);
			Stream.NativeMethodInfoPtr_BlockingBeginRead_Internal_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100668851);
			Stream.NativeMethodInfoPtr_BlockingEndRead_Internal_Static_Int32_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100668852);
			Stream.NativeMethodInfoPtr_BlockingBeginWrite_Internal_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100668853);
			Stream.NativeMethodInfoPtr_BlockingEndWrite_Internal_Static_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100668854);
			Stream.NativeMethodInfoPtr__ctor_Protected_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream>.NativeClassPtr, 100668855);
		}

		// Token: 0x06002166 RID: 8550 RVA: 0x000B8600 File Offset: 0x000B6800
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 321344, RefRangeEnd = 321348, XrefRangeStart = 321326, XrefRangeEnd = 321344, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SemaphoreSlim EnsureAsyncActiveSemaphoreInitialized()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NativeMethodInfoPtr_EnsureAsyncActiveSemaphoreInitialized_Internal_SemaphoreSlim_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<SemaphoreSlim>(intPtr3) : null;
		}

		// Token: 0x170006F4 RID: 1780
		// (get) Token: 0x06002167 RID: 8551 RVA: 0x000B8640 File Offset: 0x000B6840
		public unsafe virtual bool CanRead
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stream.NativeMethodInfoPtr_get_CanRead_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006F5 RID: 1781
		// (get) Token: 0x06002168 RID: 8552 RVA: 0x000B8688 File Offset: 0x000B6888
		public unsafe virtual bool CanSeek
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stream.NativeMethodInfoPtr_get_CanSeek_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006F6 RID: 1782
		// (get) Token: 0x06002169 RID: 8553 RVA: 0x000B86D0 File Offset: 0x000B68D0
		public unsafe virtual bool CanWrite
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stream.NativeMethodInfoPtr_get_CanWrite_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006F7 RID: 1783
		// (get) Token: 0x0600216A RID: 8554 RVA: 0x000B8718 File Offset: 0x000B6918
		public unsafe virtual long Length
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stream.NativeMethodInfoPtr_get_Length_Public_Abstract_Virtual_New_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170006F8 RID: 1784
		// (get) Token: 0x0600216B RID: 8555 RVA: 0x000B8760 File Offset: 0x000B6960
		// (set) Token: 0x0600216C RID: 8556 RVA: 0x000B87A8 File Offset: 0x000B69A8
		public unsafe virtual long Position
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stream.NativeMethodInfoPtr_get_Position_Public_Abstract_Virtual_New_get_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stream.NativeMethodInfoPtr_set_Position_Public_Abstract_Virtual_New_set_Void_Int64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006F9 RID: 1785
		// (get) Token: 0x0600216D RID: 8557 RVA: 0x000B87F4 File Offset: 0x000B69F4
		// (set) Token: 0x0600216E RID: 8558 RVA: 0x000B883C File Offset: 0x000B6A3C
		public unsafe virtual int ReadTimeout
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321348, XrefRangeEnd = 321355, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stream.NativeMethodInfoPtr_get_ReadTimeout_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321355, XrefRangeEnd = 321362, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stream.NativeMethodInfoPtr_set_ReadTimeout_Public_Virtual_New_set_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}
		}

		// Token: 0x170006FA RID: 1786
		// (get) Token: 0x0600216F RID: 8559 RVA: 0x000B8888 File Offset: 0x000B6A88
		public unsafe virtual int WriteTimeout
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321362, XrefRangeEnd = 321369, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stream.NativeMethodInfoPtr_get_WriteTimeout_Public_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002170 RID: 8560 RVA: 0x000B88D0 File Offset: 0x000B6AD0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321369, XrefRangeEnd = 321373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Close()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stream.NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002171 RID: 8561 RVA: 0x000B890C File Offset: 0x000B6B0C
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 321373, RefRangeEnd = 321379, XrefRangeStart = 321373, XrefRangeEnd = 321373, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002172 RID: 8562 RVA: 0x000B8940 File Offset: 0x000B6B40
		[CallerCount(3728)]
		[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Dispose(bool disposing)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref disposing;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stream.NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002173 RID: 8563 RVA: 0x000B898C File Offset: 0x000B6B8C
		[CallerCount(0)]
		public unsafe virtual void Flush()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stream.NativeMethodInfoPtr_Flush_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002174 RID: 8564 RVA: 0x000B89C8 File Offset: 0x000B6BC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321379, XrefRangeEnd = 321380, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IAsyncResult BeginRead(Il2CppStructArray<byte> buffer, int offset, int count, AsyncCallback callback, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stream.NativeMethodInfoPtr_BeginRead_Public_Virtual_New_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06002175 RID: 8565 RVA: 0x000B8A68 File Offset: 0x000B6C68
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 321409, RefRangeEnd = 321410, XrefRangeStart = 321380, XrefRangeEnd = 321409, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginReadInternal(Il2CppStructArray<byte> buffer, int offset, int count, AsyncCallback callback, Object state, bool serializeAsynchronously)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref serializeAsynchronously;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NativeMethodInfoPtr_BeginReadInternal_Internal_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06002176 RID: 8566 RVA: 0x000B8B08 File Offset: 0x000B6D08
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 321421, RefRangeEnd = 321422, XrefRangeStart = 321410, XrefRangeEnd = 321421, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int EndRead(IAsyncResult asyncResult)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stream.NativeMethodInfoPtr_EndRead_Public_Virtual_New_Int32_IAsyncResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002177 RID: 8567 RVA: 0x000B8B60 File Offset: 0x000B6D60
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 321431, RefRangeEnd = 321432, XrefRangeStart = 321422, XrefRangeEnd = 321431, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task<int> ReadAsync(Il2CppStructArray<byte> buffer, int offset, int count, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stream.NativeMethodInfoPtr_ReadAsync_Public_Virtual_New_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<int>>(intPtr3) : null;
		}

		// Token: 0x06002178 RID: 8568 RVA: 0x000B8BF0 File Offset: 0x000B6DF0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 321464, RefRangeEnd = 321465, XrefRangeStart = 321432, XrefRangeEnd = 321464, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task<int> BeginEndReadAsync(Il2CppStructArray<byte> buffer, int offset, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NativeMethodInfoPtr_BeginEndReadAsync_Private_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<int>>(intPtr3) : null;
		}

		// Token: 0x06002179 RID: 8569 RVA: 0x000B8C5C File Offset: 0x000B6E5C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321465, XrefRangeEnd = 321466, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual IAsyncResult BeginWrite(Il2CppStructArray<byte> buffer, int offset, int count, AsyncCallback callback, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stream.NativeMethodInfoPtr_BeginWrite_Public_Virtual_New_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x0600217A RID: 8570 RVA: 0x000B8CFC File Offset: 0x000B6EFC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 321495, RefRangeEnd = 321496, XrefRangeStart = 321466, XrefRangeEnd = 321495, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BeginWriteInternal(Il2CppStructArray<byte> buffer, int offset, int count, AsyncCallback callback, Object state, bool serializeAsynchronously)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref serializeAsynchronously;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NativeMethodInfoPtr_BeginWriteInternal_Internal_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x0600217B RID: 8571 RVA: 0x000B8D9C File Offset: 0x000B6F9C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 321524, RefRangeEnd = 321526, XrefRangeStart = 321496, XrefRangeEnd = 321524, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RunReadWriteTaskWhenReady(Task asyncWaiter, Stream.ReadWriteTask readWriteTask)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncWaiter);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(readWriteTask);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NativeMethodInfoPtr_RunReadWriteTaskWhenReady_Private_Void_Task_ReadWriteTask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600217C RID: 8572 RVA: 0x000B8DF0 File Offset: 0x000B6FF0
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 321536, RefRangeEnd = 321539, XrefRangeStart = 321526, XrefRangeEnd = 321536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RunReadWriteTask(Stream.ReadWriteTask readWriteTask)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(readWriteTask);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NativeMethodInfoPtr_RunReadWriteTask_Private_Void_ReadWriteTask_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600217D RID: 8573 RVA: 0x000B8E34 File Offset: 0x000B7034
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 321554, RefRangeEnd = 321555, XrefRangeStart = 321539, XrefRangeEnd = 321554, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void EndWrite(IAsyncResult asyncResult)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stream.NativeMethodInfoPtr_EndWrite_Public_Virtual_New_Void_IAsyncResult_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600217E RID: 8574 RVA: 0x000B8E84 File Offset: 0x000B7084
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 321559, RefRangeEnd = 321561, XrefRangeStart = 321555, XrefRangeEnd = 321559, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task WriteAsync(Il2CppStructArray<byte> buffer, int offset, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NativeMethodInfoPtr_WriteAsync_Public_Task_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x0600217F RID: 8575 RVA: 0x000B8EF0 File Offset: 0x000B70F0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 321568, RefRangeEnd = 321569, XrefRangeStart = 321561, XrefRangeEnd = 321568, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual Task WriteAsync(Il2CppStructArray<byte> buffer, int offset, int count, CancellationToken cancellationToken)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stream.NativeMethodInfoPtr_WriteAsync_Public_Virtual_New_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06002180 RID: 8576 RVA: 0x000B8F80 File Offset: 0x000B7180
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 321601, RefRangeEnd = 321602, XrefRangeStart = 321569, XrefRangeEnd = 321601, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Task BeginEndWriteAsync(Il2CppStructArray<byte> buffer, int offset, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NativeMethodInfoPtr_BeginEndWriteAsync_Private_Task_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
		}

		// Token: 0x06002181 RID: 8577 RVA: 0x000B8FEC File Offset: 0x000B71EC
		[CallerCount(0)]
		public unsafe virtual long Seek(long offset, SeekOrigin origin)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref offset;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref origin;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stream.NativeMethodInfoPtr_Seek_Public_Abstract_Virtual_New_Int64_Int64_SeekOrigin_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002182 RID: 8578 RVA: 0x000B9050 File Offset: 0x000B7250
		[CallerCount(0)]
		public unsafe virtual int Read([In] [Out] Il2CppStructArray<byte> buffer, int offset, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			IntPtr intPtr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				intPtr = 0;
				ptr2 = &intPtr;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stream.NativeMethodInfoPtr_Read_Public_Abstract_Virtual_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			IntPtr intPtr4 = intPtr;
			*buffer = ((intPtr4 == 0) ? null : new Il2CppStructArray<byte>(intPtr4));
			return *IL2CPP.il2cpp_object_unbox(intPtr2);
		}

		// Token: 0x06002183 RID: 8579 RVA: 0x000B90D8 File Offset: 0x000B72D8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321602, XrefRangeEnd = 321605, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual int ReadByte()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stream.NativeMethodInfoPtr_ReadByte_Public_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06002184 RID: 8580 RVA: 0x000B9120 File Offset: 0x000B7320
		[CallerCount(0)]
		public unsafe virtual void Write(Il2CppStructArray<byte> buffer, int offset, int count)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stream.NativeMethodInfoPtr_Write_Public_Abstract_Virtual_New_Void_Il2CppStructArray_1_Byte_Int32_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002185 RID: 8581 RVA: 0x000B918C File Offset: 0x000B738C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321605, XrefRangeEnd = 321608, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void WriteByte(byte value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref value;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), Stream.NativeMethodInfoPtr_WriteByte_Public_Virtual_New_Void_Byte_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06002186 RID: 8582 RVA: 0x000B91D8 File Offset: 0x000B73D8
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 321617, RefRangeEnd = 321618, XrefRangeStart = 321608, XrefRangeEnd = 321617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BlockingBeginRead(Il2CppStructArray<byte> buffer, int offset, int count, AsyncCallback callback, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NativeMethodInfoPtr_BlockingBeginRead_Internal_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06002187 RID: 8583 RVA: 0x000B926C File Offset: 0x000B746C
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 321619, RefRangeEnd = 321620, XrefRangeStart = 321618, XrefRangeEnd = 321619, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static int BlockingEndRead(IAsyncResult asyncResult)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NativeMethodInfoPtr_BlockingEndRead_Internal_Static_Int32_IAsyncResult_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06002188 RID: 8584 RVA: 0x000B92B0 File Offset: 0x000B74B0
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 321629, RefRangeEnd = 321630, XrefRangeStart = 321620, XrefRangeEnd = 321629, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IAsyncResult BlockingBeginWrite(Il2CppStructArray<byte> buffer, int offset, int count, AsyncCallback callback, Object state)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NativeMethodInfoPtr_BlockingBeginWrite_Internal_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
		}

		// Token: 0x06002189 RID: 8585 RVA: 0x000B9344 File Offset: 0x000B7544
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 321631, RefRangeEnd = 321632, XrefRangeStart = 321630, XrefRangeEnd = 321631, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void BlockingEndWrite(IAsyncResult asyncResult)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NativeMethodInfoPtr_BlockingEndWrite_Internal_Static_Void_IAsyncResult_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600218A RID: 8586 RVA: 0x000B937C File Offset: 0x000B757C
		[CallerCount(114)]
		[CachedScanResults(RefRangeStart = 12105, RefRangeEnd = 12219, XrefRangeStart = 12105, XrefRangeEnd = 12219, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Stream()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Stream>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NativeMethodInfoPtr__ctor_Protected_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600218B RID: 8587 RVA: 0x0000B522 File Offset: 0x00009722
		public Stream(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170006F1 RID: 1777
		// (get) Token: 0x0600218C RID: 8588 RVA: 0x000B93B8 File Offset: 0x000B75B8
		// (set) Token: 0x0600218D RID: 8589 RVA: 0x0000B52B File Offset: 0x0000972B
		public unsafe static Stream Null
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(Stream.NativeFieldInfoPtr_Null, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(Stream.NativeFieldInfoPtr_Null, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x0600218E RID: 8590 RVA: 0x000B93E0 File Offset: 0x000B75E0
		// (set) Token: 0x0600218F RID: 8591 RVA: 0x0000B53D File Offset: 0x0000973D
		public unsafe Stream.ReadWriteTask _activeReadWriteTask
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.NativeFieldInfoPtr__activeReadWriteTask);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream.ReadWriteTask>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.NativeFieldInfoPtr__activeReadWriteTask), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x170006F3 RID: 1779
		// (get) Token: 0x06002190 RID: 8592 RVA: 0x000B9410 File Offset: 0x000B7610
		// (set) Token: 0x06002191 RID: 8593 RVA: 0x0000B55C File Offset: 0x0000975C
		public unsafe SemaphoreSlim _asyncActiveSemaphore
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.NativeFieldInfoPtr__asyncActiveSemaphore);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<SemaphoreSlim>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.NativeFieldInfoPtr__asyncActiveSemaphore), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001DF3 RID: 7667
		private static readonly IntPtr NativeFieldInfoPtr_Null;

		// Token: 0x04001DF4 RID: 7668
		private static readonly IntPtr NativeFieldInfoPtr__activeReadWriteTask;

		// Token: 0x04001DF5 RID: 7669
		private static readonly IntPtr NativeFieldInfoPtr__asyncActiveSemaphore;

		// Token: 0x04001DF6 RID: 7670
		private static readonly IntPtr NativeMethodInfoPtr_EnsureAsyncActiveSemaphoreInitialized_Internal_SemaphoreSlim_0;

		// Token: 0x04001DF7 RID: 7671
		private static readonly IntPtr NativeMethodInfoPtr_get_CanRead_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04001DF8 RID: 7672
		private static readonly IntPtr NativeMethodInfoPtr_get_CanSeek_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04001DF9 RID: 7673
		private static readonly IntPtr NativeMethodInfoPtr_get_CanWrite_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x04001DFA RID: 7674
		private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_Abstract_Virtual_New_get_Int64_0;

		// Token: 0x04001DFB RID: 7675
		private static readonly IntPtr NativeMethodInfoPtr_get_Position_Public_Abstract_Virtual_New_get_Int64_0;

		// Token: 0x04001DFC RID: 7676
		private static readonly IntPtr NativeMethodInfoPtr_set_Position_Public_Abstract_Virtual_New_set_Void_Int64_0;

		// Token: 0x04001DFD RID: 7677
		private static readonly IntPtr NativeMethodInfoPtr_get_ReadTimeout_Public_Virtual_New_get_Int32_0;

		// Token: 0x04001DFE RID: 7678
		private static readonly IntPtr NativeMethodInfoPtr_set_ReadTimeout_Public_Virtual_New_set_Void_Int32_0;

		// Token: 0x04001DFF RID: 7679
		private static readonly IntPtr NativeMethodInfoPtr_get_WriteTimeout_Public_Virtual_New_get_Int32_0;

		// Token: 0x04001E00 RID: 7680
		private static readonly IntPtr NativeMethodInfoPtr_Close_Public_Virtual_New_Void_0;

		// Token: 0x04001E01 RID: 7681
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Public_Virtual_Final_New_Void_0;

		// Token: 0x04001E02 RID: 7682
		private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_New_Void_Boolean_0;

		// Token: 0x04001E03 RID: 7683
		private static readonly IntPtr NativeMethodInfoPtr_Flush_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04001E04 RID: 7684
		private static readonly IntPtr NativeMethodInfoPtr_BeginRead_Public_Virtual_New_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0;

		// Token: 0x04001E05 RID: 7685
		private static readonly IntPtr NativeMethodInfoPtr_BeginReadInternal_Internal_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_Boolean_0;

		// Token: 0x04001E06 RID: 7686
		private static readonly IntPtr NativeMethodInfoPtr_EndRead_Public_Virtual_New_Int32_IAsyncResult_0;

		// Token: 0x04001E07 RID: 7687
		private static readonly IntPtr NativeMethodInfoPtr_ReadAsync_Public_Virtual_New_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0;

		// Token: 0x04001E08 RID: 7688
		private static readonly IntPtr NativeMethodInfoPtr_BeginEndReadAsync_Private_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04001E09 RID: 7689
		private static readonly IntPtr NativeMethodInfoPtr_BeginWrite_Public_Virtual_New_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0;

		// Token: 0x04001E0A RID: 7690
		private static readonly IntPtr NativeMethodInfoPtr_BeginWriteInternal_Internal_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_Boolean_0;

		// Token: 0x04001E0B RID: 7691
		private static readonly IntPtr NativeMethodInfoPtr_RunReadWriteTaskWhenReady_Private_Void_Task_ReadWriteTask_0;

		// Token: 0x04001E0C RID: 7692
		private static readonly IntPtr NativeMethodInfoPtr_RunReadWriteTask_Private_Void_ReadWriteTask_0;

		// Token: 0x04001E0D RID: 7693
		private static readonly IntPtr NativeMethodInfoPtr_EndWrite_Public_Virtual_New_Void_IAsyncResult_0;

		// Token: 0x04001E0E RID: 7694
		private static readonly IntPtr NativeMethodInfoPtr_WriteAsync_Public_Task_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04001E0F RID: 7695
		private static readonly IntPtr NativeMethodInfoPtr_WriteAsync_Public_Virtual_New_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0;

		// Token: 0x04001E10 RID: 7696
		private static readonly IntPtr NativeMethodInfoPtr_BeginEndWriteAsync_Private_Task_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04001E11 RID: 7697
		private static readonly IntPtr NativeMethodInfoPtr_Seek_Public_Abstract_Virtual_New_Int64_Int64_SeekOrigin_0;

		// Token: 0x04001E12 RID: 7698
		private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Abstract_Virtual_New_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04001E13 RID: 7699
		private static readonly IntPtr NativeMethodInfoPtr_ReadByte_Public_Virtual_New_Int32_0;

		// Token: 0x04001E14 RID: 7700
		private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Abstract_Virtual_New_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

		// Token: 0x04001E15 RID: 7701
		private static readonly IntPtr NativeMethodInfoPtr_WriteByte_Public_Virtual_New_Void_Byte_0;

		// Token: 0x04001E16 RID: 7702
		private static readonly IntPtr NativeMethodInfoPtr_BlockingBeginRead_Internal_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0;

		// Token: 0x04001E17 RID: 7703
		private static readonly IntPtr NativeMethodInfoPtr_BlockingEndRead_Internal_Static_Int32_IAsyncResult_0;

		// Token: 0x04001E18 RID: 7704
		private static readonly IntPtr NativeMethodInfoPtr_BlockingBeginWrite_Internal_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0;

		// Token: 0x04001E19 RID: 7705
		private static readonly IntPtr NativeMethodInfoPtr_BlockingEndWrite_Internal_Static_Void_IAsyncResult_0;

		// Token: 0x04001E1A RID: 7706
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Protected_Void_0;

		// Token: 0x020005CE RID: 1486
		public sealed class ReadWriteParameters : ValueType
		{
			// Token: 0x06005141 RID: 20801 RVA: 0x0016B4D4 File Offset: 0x001696D4
			// Note: this type is marked as 'beforefieldinit'.
			static ReadWriteParameters()
			{
				Il2CppClassPointerStore<Stream.ReadWriteParameters>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Stream>.NativeClassPtr, "ReadWriteParameters");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Stream.ReadWriteParameters>.NativeClassPtr);
				Stream.ReadWriteParameters.NativeFieldInfoPtr_Buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.ReadWriteParameters>.NativeClassPtr, "Buffer");
				Stream.ReadWriteParameters.NativeFieldInfoPtr_Offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.ReadWriteParameters>.NativeClassPtr, "Offset");
				Stream.ReadWriteParameters.NativeFieldInfoPtr_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.ReadWriteParameters>.NativeClassPtr, "Count");
			}

			// Token: 0x06005142 RID: 20802 RVA: 0x0001EFF5 File Offset: 0x0001D1F5
			public ReadWriteParameters(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06005143 RID: 20803 RVA: 0x0001EFFE File Offset: 0x0001D1FE
			public ReadWriteParameters()
				: base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Stream.ReadWriteParameters>.NativeClassPtr))
			{
			}

			// Token: 0x170014C3 RID: 5315
			// (get) Token: 0x06005144 RID: 20804 RVA: 0x0016B53C File Offset: 0x0016973C
			// (set) Token: 0x06005145 RID: 20805 RVA: 0x0001F010 File Offset: 0x0001D210
			public unsafe Il2CppStructArray<byte> Buffer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.ReadWriteParameters.NativeFieldInfoPtr_Buffer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.ReadWriteParameters.NativeFieldInfoPtr_Buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170014C4 RID: 5316
			// (get) Token: 0x06005146 RID: 20806 RVA: 0x0016B56C File Offset: 0x0016976C
			// (set) Token: 0x06005147 RID: 20807 RVA: 0x0001F02F File Offset: 0x0001D22F
			public unsafe int Offset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.ReadWriteParameters.NativeFieldInfoPtr_Offset);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.ReadWriteParameters.NativeFieldInfoPtr_Offset)) = value;
				}
			}

			// Token: 0x170014C5 RID: 5317
			// (get) Token: 0x06005148 RID: 20808 RVA: 0x0016B594 File Offset: 0x00169794
			// (set) Token: 0x06005149 RID: 20809 RVA: 0x0001F04A File Offset: 0x0001D24A
			public unsafe int Count
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.ReadWriteParameters.NativeFieldInfoPtr_Count);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.ReadWriteParameters.NativeFieldInfoPtr_Count)) = value;
				}
			}

			// Token: 0x040041D7 RID: 16855
			private static readonly IntPtr NativeFieldInfoPtr_Buffer;

			// Token: 0x040041D8 RID: 16856
			private static readonly IntPtr NativeFieldInfoPtr_Offset;

			// Token: 0x040041D9 RID: 16857
			private static readonly IntPtr NativeFieldInfoPtr_Count;
		}

		// Token: 0x020005CF RID: 1487
		public sealed class ReadWriteTask : Task<int>
		{
			// Token: 0x0600514A RID: 20810 RVA: 0x0016B5BC File Offset: 0x001697BC
			// Note: this type is marked as 'beforefieldinit'.
			static ReadWriteTask()
			{
				Il2CppClassPointerStore<Stream.ReadWriteTask>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Stream>.NativeClassPtr, "ReadWriteTask");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Stream.ReadWriteTask>.NativeClassPtr);
				Stream.ReadWriteTask.NativeFieldInfoPtr__isRead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.ReadWriteTask>.NativeClassPtr, "_isRead");
				Stream.ReadWriteTask.NativeFieldInfoPtr__stream = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.ReadWriteTask>.NativeClassPtr, "_stream");
				Stream.ReadWriteTask.NativeFieldInfoPtr__buffer = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.ReadWriteTask>.NativeClassPtr, "_buffer");
				Stream.ReadWriteTask.NativeFieldInfoPtr__offset = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.ReadWriteTask>.NativeClassPtr, "_offset");
				Stream.ReadWriteTask.NativeFieldInfoPtr__count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.ReadWriteTask>.NativeClassPtr, "_count");
				Stream.ReadWriteTask.NativeFieldInfoPtr__callback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.ReadWriteTask>.NativeClassPtr, "_callback");
				Stream.ReadWriteTask.NativeFieldInfoPtr__context = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.ReadWriteTask>.NativeClassPtr, "_context");
				Stream.ReadWriteTask.NativeFieldInfoPtr_s_invokeAsyncCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.ReadWriteTask>.NativeClassPtr, "s_invokeAsyncCallback");
				Stream.ReadWriteTask.NativeMethodInfoPtr_ClearBeginState_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.ReadWriteTask>.NativeClassPtr, 100668857);
				Stream.ReadWriteTask.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Func_2_Object_Int32_Object_Stream_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.ReadWriteTask>.NativeClassPtr, 100668858);
				Stream.ReadWriteTask.NativeMethodInfoPtr_InvokeAsyncCallback_Private_Static_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.ReadWriteTask>.NativeClassPtr, 100668859);
				Stream.ReadWriteTask.NativeMethodInfoPtr_System_Threading_Tasks_ITaskCompletionAction_Invoke_Private_Virtual_Final_New_Void_Task_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.ReadWriteTask>.NativeClassPtr, 100668860);
			}

			// Token: 0x0600514B RID: 20811 RVA: 0x0016B6D8 File Offset: 0x001698D8
			[CallerCount(0)]
			public unsafe void ClearBeginState()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.ReadWriteTask.NativeMethodInfoPtr_ClearBeginState_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600514C RID: 20812 RVA: 0x0016B70C File Offset: 0x0016990C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 321174, RefRangeEnd = 321176, XrefRangeStart = 321159, XrefRangeEnd = 321174, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ReadWriteTask(bool isRead, Func<Object, int> function, Object state, Stream stream, Il2CppStructArray<byte> buffer, int offset, int count, AsyncCallback callback)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Stream.ReadWriteTask>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)8) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref isRead;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(function);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(stream);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(buffer);
				ptr[checked(unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
				ptr[checked(unchecked((UIntPtr)6) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
				ptr[checked(unchecked((UIntPtr)7) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.ReadWriteTask.NativeMethodInfoPtr__ctor_Public_Void_Boolean_Func_2_Object_Int32_Object_Stream_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600514D RID: 20813 RVA: 0x0016B7CC File Offset: 0x001699CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321176, XrefRangeEnd = 321181, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void InvokeAsyncCallback(Object completedTask)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(completedTask);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.ReadWriteTask.NativeMethodInfoPtr_InvokeAsyncCallback_Private_Static_Void_Object_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600514E RID: 20814 RVA: 0x0016B804 File Offset: 0x00169A04
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321181, XrefRangeEnd = 321202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Threading_Tasks_ITaskCompletionAction_Invoke(Task completingTask)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(completingTask);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.ReadWriteTask.NativeMethodInfoPtr_System_Threading_Tasks_ITaskCompletionAction_Invoke_Private_Virtual_Final_New_Void_Task_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600514F RID: 20815 RVA: 0x0001F065 File Offset: 0x0001D265
			public ReadWriteTask(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170014C6 RID: 5318
			// (get) Token: 0x06005150 RID: 20816 RVA: 0x0016B848 File Offset: 0x00169A48
			// (set) Token: 0x06005151 RID: 20817 RVA: 0x0001F06E File Offset: 0x0001D26E
			public unsafe bool _isRead
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.ReadWriteTask.NativeFieldInfoPtr__isRead);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.ReadWriteTask.NativeFieldInfoPtr__isRead)) = value;
				}
			}

			// Token: 0x170014C7 RID: 5319
			// (get) Token: 0x06005152 RID: 20818 RVA: 0x0016B870 File Offset: 0x00169A70
			// (set) Token: 0x06005153 RID: 20819 RVA: 0x0001F089 File Offset: 0x0001D289
			public unsafe Stream _stream
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.ReadWriteTask.NativeFieldInfoPtr__stream);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.ReadWriteTask.NativeFieldInfoPtr__stream), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170014C8 RID: 5320
			// (get) Token: 0x06005154 RID: 20820 RVA: 0x0016B8A0 File Offset: 0x00169AA0
			// (set) Token: 0x06005155 RID: 20821 RVA: 0x0001F0A8 File Offset: 0x0001D2A8
			public unsafe Il2CppStructArray<byte> _buffer
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.ReadWriteTask.NativeFieldInfoPtr__buffer);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStructArray<byte>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.ReadWriteTask.NativeFieldInfoPtr__buffer), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170014C9 RID: 5321
			// (get) Token: 0x06005156 RID: 20822 RVA: 0x0016B8D0 File Offset: 0x00169AD0
			// (set) Token: 0x06005157 RID: 20823 RVA: 0x0001F0C7 File Offset: 0x0001D2C7
			public unsafe int _offset
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.ReadWriteTask.NativeFieldInfoPtr__offset);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.ReadWriteTask.NativeFieldInfoPtr__offset)) = value;
				}
			}

			// Token: 0x170014CA RID: 5322
			// (get) Token: 0x06005158 RID: 20824 RVA: 0x0016B8F8 File Offset: 0x00169AF8
			// (set) Token: 0x06005159 RID: 20825 RVA: 0x0001F0E2 File Offset: 0x0001D2E2
			public unsafe int _count
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.ReadWriteTask.NativeFieldInfoPtr__count);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.ReadWriteTask.NativeFieldInfoPtr__count)) = value;
				}
			}

			// Token: 0x170014CB RID: 5323
			// (get) Token: 0x0600515A RID: 20826 RVA: 0x0016B920 File Offset: 0x00169B20
			// (set) Token: 0x0600515B RID: 20827 RVA: 0x0001F0FD File Offset: 0x0001D2FD
			public unsafe AsyncCallback _callback
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.ReadWriteTask.NativeFieldInfoPtr__callback);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncCallback>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.ReadWriteTask.NativeFieldInfoPtr__callback), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170014CC RID: 5324
			// (get) Token: 0x0600515C RID: 20828 RVA: 0x0016B950 File Offset: 0x00169B50
			// (set) Token: 0x0600515D RID: 20829 RVA: 0x0001F11C File Offset: 0x0001D31C
			public unsafe ExecutionContext _context
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.ReadWriteTask.NativeFieldInfoPtr__context);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExecutionContext>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.ReadWriteTask.NativeFieldInfoPtr__context), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170014CD RID: 5325
			// (get) Token: 0x0600515E RID: 20830 RVA: 0x0016B980 File Offset: 0x00169B80
			// (set) Token: 0x0600515F RID: 20831 RVA: 0x0001F13B File Offset: 0x0001D33B
			public unsafe static ContextCallback s_invokeAsyncCallback
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Stream.ReadWriteTask.NativeFieldInfoPtr_s_invokeAsyncCallback, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ContextCallback>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Stream.ReadWriteTask.NativeFieldInfoPtr_s_invokeAsyncCallback, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040041DA RID: 16858
			private static readonly IntPtr NativeFieldInfoPtr__isRead;

			// Token: 0x040041DB RID: 16859
			private static readonly IntPtr NativeFieldInfoPtr__stream;

			// Token: 0x040041DC RID: 16860
			private static readonly IntPtr NativeFieldInfoPtr__buffer;

			// Token: 0x040041DD RID: 16861
			private static readonly IntPtr NativeFieldInfoPtr__offset;

			// Token: 0x040041DE RID: 16862
			private static readonly IntPtr NativeFieldInfoPtr__count;

			// Token: 0x040041DF RID: 16863
			private static readonly IntPtr NativeFieldInfoPtr__callback;

			// Token: 0x040041E0 RID: 16864
			private static readonly IntPtr NativeFieldInfoPtr__context;

			// Token: 0x040041E1 RID: 16865
			private static readonly IntPtr NativeFieldInfoPtr_s_invokeAsyncCallback;

			// Token: 0x040041E2 RID: 16866
			private static readonly IntPtr NativeMethodInfoPtr_ClearBeginState_Internal_Void_0;

			// Token: 0x040041E3 RID: 16867
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_Func_2_Object_Int32_Object_Stream_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_0;

			// Token: 0x040041E4 RID: 16868
			private static readonly IntPtr NativeMethodInfoPtr_InvokeAsyncCallback_Private_Static_Void_Object_0;

			// Token: 0x040041E5 RID: 16869
			private static readonly IntPtr NativeMethodInfoPtr_System_Threading_Tasks_ITaskCompletionAction_Invoke_Private_Virtual_Final_New_Void_Task_0;
		}

		// Token: 0x020005D0 RID: 1488
		[Serializable]
		public sealed class NullStream : Stream
		{
			// Token: 0x06005160 RID: 20832 RVA: 0x0016B9A8 File Offset: 0x00169BA8
			// Note: this type is marked as 'beforefieldinit'.
			static NullStream()
			{
				Il2CppClassPointerStore<Stream.NullStream>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Stream>.NativeClassPtr, "NullStream");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Stream.NullStream>.NativeClassPtr);
				Stream.NullStream.NativeFieldInfoPtr_s_nullReadTask = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.NullStream>.NativeClassPtr, "s_nullReadTask");
				Stream.NullStream.NativeMethodInfoPtr__ctor_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.NullStream>.NativeClassPtr, 100668861);
				Stream.NullStream.NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.NullStream>.NativeClassPtr, 100668862);
				Stream.NullStream.NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.NullStream>.NativeClassPtr, 100668863);
				Stream.NullStream.NativeMethodInfoPtr_get_CanSeek_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.NullStream>.NativeClassPtr, 100668864);
				Stream.NullStream.NativeMethodInfoPtr_get_Length_Public_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.NullStream>.NativeClassPtr, 100668865);
				Stream.NullStream.NativeMethodInfoPtr_get_Position_Public_Virtual_get_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.NullStream>.NativeClassPtr, 100668866);
				Stream.NullStream.NativeMethodInfoPtr_set_Position_Public_Virtual_set_Void_Int64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.NullStream>.NativeClassPtr, 100668867);
				Stream.NullStream.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.NullStream>.NativeClassPtr, 100668868);
				Stream.NullStream.NativeMethodInfoPtr_Flush_Public_Virtual_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.NullStream>.NativeClassPtr, 100668869);
				Stream.NullStream.NativeMethodInfoPtr_BeginRead_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.NullStream>.NativeClassPtr, 100668870);
				Stream.NullStream.NativeMethodInfoPtr_EndRead_Public_Virtual_Int32_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.NullStream>.NativeClassPtr, 100668871);
				Stream.NullStream.NativeMethodInfoPtr_BeginWrite_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.NullStream>.NativeClassPtr, 100668872);
				Stream.NullStream.NativeMethodInfoPtr_EndWrite_Public_Virtual_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.NullStream>.NativeClassPtr, 100668873);
				Stream.NullStream.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.NullStream>.NativeClassPtr, 100668874);
				Stream.NullStream.NativeMethodInfoPtr_ReadAsync_Public_Virtual_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.NullStream>.NativeClassPtr, 100668875);
				Stream.NullStream.NativeMethodInfoPtr_ReadByte_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.NullStream>.NativeClassPtr, 100668876);
				Stream.NullStream.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.NullStream>.NativeClassPtr, 100668877);
				Stream.NullStream.NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.NullStream>.NativeClassPtr, 100668878);
				Stream.NullStream.NativeMethodInfoPtr_WriteByte_Public_Virtual_Void_Byte_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.NullStream>.NativeClassPtr, 100668879);
				Stream.NullStream.NativeMethodInfoPtr_Seek_Public_Virtual_Int64_Int64_SeekOrigin_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.NullStream>.NativeClassPtr, 100668880);
			}

			// Token: 0x06005161 RID: 20833 RVA: 0x0016BB78 File Offset: 0x00169D78
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321202, XrefRangeEnd = 321206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe NullStream()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Stream.NullStream>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NullStream.NativeMethodInfoPtr__ctor_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170014CF RID: 5327
			// (get) Token: 0x06005162 RID: 20834 RVA: 0x0016BBB4 File Offset: 0x00169DB4
			public unsafe override bool CanRead
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 11600, RefRangeEnd = 11610, XrefRangeStart = 11600, XrefRangeEnd = 11610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NullStream.NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170014D0 RID: 5328
			// (get) Token: 0x06005163 RID: 20835 RVA: 0x0016BBF0 File Offset: 0x00169DF0
			public unsafe override bool CanWrite
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 11600, RefRangeEnd = 11610, XrefRangeStart = 11600, XrefRangeEnd = 11610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NullStream.NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170014D1 RID: 5329
			// (get) Token: 0x06005164 RID: 20836 RVA: 0x0016BC2C File Offset: 0x00169E2C
			public unsafe override bool CanSeek
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 11600, RefRangeEnd = 11610, XrefRangeStart = 11600, XrefRangeEnd = 11610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NullStream.NativeMethodInfoPtr_get_CanSeek_Public_Virtual_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170014D2 RID: 5330
			// (get) Token: 0x06005165 RID: 20837 RVA: 0x0016BC68 File Offset: 0x00169E68
			public unsafe override long Length
			{
				[CallerCount(23)]
				[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NullStream.NativeMethodInfoPtr_get_Length_Public_Virtual_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170014D3 RID: 5331
			// (get) Token: 0x06005166 RID: 20838 RVA: 0x0016BCA4 File Offset: 0x00169EA4
			// (set) Token: 0x06005167 RID: 20839 RVA: 0x0016BCE0 File Offset: 0x00169EE0
			public unsafe override long Position
			{
				[CallerCount(23)]
				[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NullStream.NativeMethodInfoPtr_get_Position_Public_Virtual_get_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
				[CallerCount(3728)]
				[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				set
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					checked
					{
						IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
						*ptr = ref value;
						IntPtr intPtr2;
						IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NullStream.NativeMethodInfoPtr_set_Position_Public_Virtual_set_Void_Int64_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
						Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					}
				}
			}

			// Token: 0x06005168 RID: 20840 RVA: 0x0016BD20 File Offset: 0x00169F20
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Dispose(bool disposing)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref disposing;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NullStream.NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005169 RID: 20841 RVA: 0x0016BD60 File Offset: 0x00169F60
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Flush()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NullStream.NativeMethodInfoPtr_Flush_Public_Virtual_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600516A RID: 20842 RVA: 0x0016BD94 File Offset: 0x00169F94
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321206, XrefRangeEnd = 321208, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override IAsyncResult BeginRead(Il2CppStructArray<byte> buffer, int offset, int count, AsyncCallback callback, Object state)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NullStream.NativeMethodInfoPtr_BeginRead_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600516B RID: 20843 RVA: 0x0016BE28 File Offset: 0x0016A028
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321208, XrefRangeEnd = 321218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int EndRead(IAsyncResult asyncResult)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NullStream.NativeMethodInfoPtr_EndRead_Public_Virtual_Int32_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x0600516C RID: 20844 RVA: 0x0016BE78 File Offset: 0x0016A078
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321218, XrefRangeEnd = 321220, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override IAsyncResult BeginWrite(Il2CppStructArray<byte> buffer, int offset, int count, AsyncCallback callback, Object state)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NullStream.NativeMethodInfoPtr_BeginWrite_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x0600516D RID: 20845 RVA: 0x0016BF0C File Offset: 0x0016A10C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321220, XrefRangeEnd = 321230, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void EndWrite(IAsyncResult asyncResult)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NullStream.NativeMethodInfoPtr_EndWrite_Public_Virtual_Void_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600516E RID: 20846 RVA: 0x0016BF50 File Offset: 0x0016A150
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override int Read([In] [Out] Il2CppStructArray<byte> buffer, int offset, int count)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				IntPtr intPtr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					intPtr = 0;
					ptr2 = &intPtr;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(Stream.NullStream.NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				IntPtr intPtr4 = intPtr;
				*buffer = ((intPtr4 == 0) ? null : new Il2CppStructArray<byte>(intPtr4));
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}

			// Token: 0x0600516F RID: 20847 RVA: 0x0016BFCC File Offset: 0x0016A1CC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321230, XrefRangeEnd = 321243, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Task<int> ReadAsync(Il2CppStructArray<byte> buffer, int offset, int count, CancellationToken cancellationToken)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NullStream.NativeMethodInfoPtr_ReadAsync_Public_Virtual_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task<int>>(intPtr3) : null;
			}

			// Token: 0x06005170 RID: 20848 RVA: 0x0016C050 File Offset: 0x0016A250
			[CallerCount(0)]
			public unsafe override int ReadByte()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NullStream.NativeMethodInfoPtr_ReadByte_Public_Virtual_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005171 RID: 20849 RVA: 0x0016C08C File Offset: 0x0016A28C
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void Write(Il2CppStructArray<byte> buffer, int offset, int count)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NullStream.NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005172 RID: 20850 RVA: 0x0016C0EC File Offset: 0x0016A2EC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321243, XrefRangeEnd = 321248, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override Task WriteAsync(Il2CppStructArray<byte> buffer, int offset, int count, CancellationToken cancellationToken)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(buffer);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref offset;
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref count;
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(cancellationToken));
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NullStream.NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Task>(intPtr3) : null;
			}

			// Token: 0x06005173 RID: 20851 RVA: 0x0016C170 File Offset: 0x0016A370
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override void WriteByte(byte value)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref value;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NullStream.NativeMethodInfoPtr_WriteByte_Public_Virtual_Void_Byte_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005174 RID: 20852 RVA: 0x0016C1B0 File Offset: 0x0016A3B0
			[CallerCount(23)]
			[CachedScanResults(RefRangeStart = 11853, RefRangeEnd = 11876, XrefRangeStart = 11853, XrefRangeEnd = 11876, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe override long Seek(long offset, SeekOrigin origin)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref offset;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref origin;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.NullStream.NativeMethodInfoPtr_Seek_Public_Virtual_Int64_Int64_SeekOrigin_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005175 RID: 20853 RVA: 0x0001F14D File Offset: 0x0001D34D
			public NullStream(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170014CE RID: 5326
			// (get) Token: 0x06005176 RID: 20854 RVA: 0x0016C208 File Offset: 0x0016A408
			// (set) Token: 0x06005177 RID: 20855 RVA: 0x0001F156 File Offset: 0x0001D356
			public unsafe static Task<int> s_nullReadTask
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Stream.NullStream.NativeFieldInfoPtr_s_nullReadTask, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Task<int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Stream.NullStream.NativeFieldInfoPtr_s_nullReadTask, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040041E6 RID: 16870
			private static readonly IntPtr NativeFieldInfoPtr_s_nullReadTask;

			// Token: 0x040041E7 RID: 16871
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_0;

			// Token: 0x040041E8 RID: 16872
			private static readonly IntPtr NativeMethodInfoPtr_get_CanRead_Public_Virtual_get_Boolean_0;

			// Token: 0x040041E9 RID: 16873
			private static readonly IntPtr NativeMethodInfoPtr_get_CanWrite_Public_Virtual_get_Boolean_0;

			// Token: 0x040041EA RID: 16874
			private static readonly IntPtr NativeMethodInfoPtr_get_CanSeek_Public_Virtual_get_Boolean_0;

			// Token: 0x040041EB RID: 16875
			private static readonly IntPtr NativeMethodInfoPtr_get_Length_Public_Virtual_get_Int64_0;

			// Token: 0x040041EC RID: 16876
			private static readonly IntPtr NativeMethodInfoPtr_get_Position_Public_Virtual_get_Int64_0;

			// Token: 0x040041ED RID: 16877
			private static readonly IntPtr NativeMethodInfoPtr_set_Position_Public_Virtual_set_Void_Int64_0;

			// Token: 0x040041EE RID: 16878
			private static readonly IntPtr NativeMethodInfoPtr_Dispose_Protected_Virtual_Void_Boolean_0;

			// Token: 0x040041EF RID: 16879
			private static readonly IntPtr NativeMethodInfoPtr_Flush_Public_Virtual_Void_0;

			// Token: 0x040041F0 RID: 16880
			private static readonly IntPtr NativeMethodInfoPtr_BeginRead_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0;

			// Token: 0x040041F1 RID: 16881
			private static readonly IntPtr NativeMethodInfoPtr_EndRead_Public_Virtual_Int32_IAsyncResult_0;

			// Token: 0x040041F2 RID: 16882
			private static readonly IntPtr NativeMethodInfoPtr_BeginWrite_Public_Virtual_IAsyncResult_Il2CppStructArray_1_Byte_Int32_Int32_AsyncCallback_Object_0;

			// Token: 0x040041F3 RID: 16883
			private static readonly IntPtr NativeMethodInfoPtr_EndWrite_Public_Virtual_Void_IAsyncResult_0;

			// Token: 0x040041F4 RID: 16884
			private static readonly IntPtr NativeMethodInfoPtr_Read_Public_Virtual_Int32_Il2CppStructArray_1_Byte_Int32_Int32_0;

			// Token: 0x040041F5 RID: 16885
			private static readonly IntPtr NativeMethodInfoPtr_ReadAsync_Public_Virtual_Task_1_Int32_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0;

			// Token: 0x040041F6 RID: 16886
			private static readonly IntPtr NativeMethodInfoPtr_ReadByte_Public_Virtual_Int32_0;

			// Token: 0x040041F7 RID: 16887
			private static readonly IntPtr NativeMethodInfoPtr_Write_Public_Virtual_Void_Il2CppStructArray_1_Byte_Int32_Int32_0;

			// Token: 0x040041F8 RID: 16888
			private static readonly IntPtr NativeMethodInfoPtr_WriteAsync_Public_Virtual_Task_Il2CppStructArray_1_Byte_Int32_Int32_CancellationToken_0;

			// Token: 0x040041F9 RID: 16889
			private static readonly IntPtr NativeMethodInfoPtr_WriteByte_Public_Virtual_Void_Byte_0;

			// Token: 0x040041FA RID: 16890
			private static readonly IntPtr NativeMethodInfoPtr_Seek_Public_Virtual_Int64_Int64_SeekOrigin_0;
		}

		// Token: 0x020005D1 RID: 1489
		public sealed class SynchronousAsyncResult : Object
		{
			// Token: 0x06005178 RID: 20856 RVA: 0x0016C230 File Offset: 0x0016A430
			// Note: this type is marked as 'beforefieldinit'.
			static SynchronousAsyncResult()
			{
				Il2CppClassPointerStore<Stream.SynchronousAsyncResult>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Stream>.NativeClassPtr, "SynchronousAsyncResult");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Stream.SynchronousAsyncResult>.NativeClassPtr);
				Stream.SynchronousAsyncResult.NativeFieldInfoPtr__stateObject = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.SynchronousAsyncResult>.NativeClassPtr, "_stateObject");
				Stream.SynchronousAsyncResult.NativeFieldInfoPtr__isWrite = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.SynchronousAsyncResult>.NativeClassPtr, "_isWrite");
				Stream.SynchronousAsyncResult.NativeFieldInfoPtr__waitHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.SynchronousAsyncResult>.NativeClassPtr, "_waitHandle");
				Stream.SynchronousAsyncResult.NativeFieldInfoPtr__exceptionInfo = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.SynchronousAsyncResult>.NativeClassPtr, "_exceptionInfo");
				Stream.SynchronousAsyncResult.NativeFieldInfoPtr__endXxxCalled = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.SynchronousAsyncResult>.NativeClassPtr, "_endXxxCalled");
				Stream.SynchronousAsyncResult.NativeFieldInfoPtr__bytesRead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.SynchronousAsyncResult>.NativeClassPtr, "_bytesRead");
				Stream.SynchronousAsyncResult.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.SynchronousAsyncResult>.NativeClassPtr, 100668881);
				Stream.SynchronousAsyncResult.NativeMethodInfoPtr__ctor_Internal_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.SynchronousAsyncResult>.NativeClassPtr, 100668882);
				Stream.SynchronousAsyncResult.NativeMethodInfoPtr__ctor_Internal_Void_Exception_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.SynchronousAsyncResult>.NativeClassPtr, 100668883);
				Stream.SynchronousAsyncResult.NativeMethodInfoPtr_get_IsCompleted_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.SynchronousAsyncResult>.NativeClassPtr, 100668884);
				Stream.SynchronousAsyncResult.NativeMethodInfoPtr_get_AsyncWaitHandle_Public_Virtual_Final_New_get_WaitHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.SynchronousAsyncResult>.NativeClassPtr, 100668885);
				Stream.SynchronousAsyncResult.NativeMethodInfoPtr_get_AsyncState_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.SynchronousAsyncResult>.NativeClassPtr, 100668886);
				Stream.SynchronousAsyncResult.NativeMethodInfoPtr_get_CompletedSynchronously_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.SynchronousAsyncResult>.NativeClassPtr, 100668887);
				Stream.SynchronousAsyncResult.NativeMethodInfoPtr_ThrowIfError_Internal_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.SynchronousAsyncResult>.NativeClassPtr, 100668888);
				Stream.SynchronousAsyncResult.NativeMethodInfoPtr_EndRead_Internal_Static_Int32_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.SynchronousAsyncResult>.NativeClassPtr, 100668889);
				Stream.SynchronousAsyncResult.NativeMethodInfoPtr_EndWrite_Internal_Static_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.SynchronousAsyncResult>.NativeClassPtr, 100668890);
			}

			// Token: 0x06005179 RID: 20857 RVA: 0x0016C39C File Offset: 0x0016A59C
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 321253, RefRangeEnd = 321254, XrefRangeStart = 321252, XrefRangeEnd = 321253, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SynchronousAsyncResult(int bytesRead, Object asyncStateObject)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Stream.SynchronousAsyncResult>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref bytesRead;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(asyncStateObject);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.SynchronousAsyncResult.NativeMethodInfoPtr__ctor_Internal_Void_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x0600517A RID: 20858 RVA: 0x0016C3F8 File Offset: 0x0016A5F8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 321255, RefRangeEnd = 321256, XrefRangeStart = 321254, XrefRangeEnd = 321255, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SynchronousAsyncResult(Object asyncStateObject)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Stream.SynchronousAsyncResult>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncStateObject);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.SynchronousAsyncResult.NativeMethodInfoPtr__ctor_Internal_Void_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x0600517B RID: 20859 RVA: 0x0016C444 File Offset: 0x0016A644
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 321258, RefRangeEnd = 321260, XrefRangeStart = 321256, XrefRangeEnd = 321258, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SynchronousAsyncResult(Exception ex, Object asyncStateObject, bool isWrite)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Stream.SynchronousAsyncResult>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(ex);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(asyncStateObject);
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref isWrite;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.SynchronousAsyncResult.NativeMethodInfoPtr__ctor_Internal_Void_Exception_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170014DA RID: 5338
			// (get) Token: 0x0600517C RID: 20860 RVA: 0x0016C4B0 File Offset: 0x0016A6B0
			public unsafe bool IsCompleted
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 11600, RefRangeEnd = 11610, XrefRangeStart = 11600, XrefRangeEnd = 11610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.SynchronousAsyncResult.NativeMethodInfoPtr_get_IsCompleted_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x170014DB RID: 5339
			// (get) Token: 0x0600517D RID: 20861 RVA: 0x0016C4EC File Offset: 0x0016A6EC
			public unsafe WaitHandle AsyncWaitHandle
			{
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321260, XrefRangeEnd = 321278, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.SynchronousAsyncResult.NativeMethodInfoPtr_get_AsyncWaitHandle_Public_Virtual_Final_New_get_WaitHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<WaitHandle>(intPtr3) : null;
				}
			}

			// Token: 0x170014DC RID: 5340
			// (get) Token: 0x0600517E RID: 20862 RVA: 0x0016C52C File Offset: 0x0016A72C
			public unsafe Object AsyncState
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.SynchronousAsyncResult.NativeMethodInfoPtr_get_AsyncState_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x170014DD RID: 5341
			// (get) Token: 0x0600517F RID: 20863 RVA: 0x0016C56C File Offset: 0x0016A76C
			public unsafe bool CompletedSynchronously
			{
				[CallerCount(10)]
				[CachedScanResults(RefRangeStart = 11600, RefRangeEnd = 11610, XrefRangeStart = 11600, XrefRangeEnd = 11610, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.SynchronousAsyncResult.NativeMethodInfoPtr_get_CompletedSynchronously_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005180 RID: 20864 RVA: 0x0016C5A8 File Offset: 0x0016A7A8
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321278, XrefRangeEnd = 321279, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void ThrowIfError()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.SynchronousAsyncResult.NativeMethodInfoPtr_ThrowIfError_Internal_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005181 RID: 20865 RVA: 0x0016C5DC File Offset: 0x0016A7DC
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 321284, RefRangeEnd = 321285, XrefRangeStart = 321279, XrefRangeEnd = 321284, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static int EndRead(IAsyncResult asyncResult)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.SynchronousAsyncResult.NativeMethodInfoPtr_EndRead_Internal_Static_Int32_IAsyncResult_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005182 RID: 20866 RVA: 0x0016C620 File Offset: 0x0016A820
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 321290, RefRangeEnd = 321292, XrefRangeStart = 321285, XrefRangeEnd = 321290, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe static void EndWrite(IAsyncResult asyncResult)
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.SynchronousAsyncResult.NativeMethodInfoPtr_EndWrite_Internal_Static_Void_IAsyncResult_0, 0, (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06005183 RID: 20867 RVA: 0x0001F168 File Offset: 0x0001D368
			public SynchronousAsyncResult(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170014D4 RID: 5332
			// (get) Token: 0x06005184 RID: 20868 RVA: 0x0016C658 File Offset: 0x0016A858
			// (set) Token: 0x06005185 RID: 20869 RVA: 0x0001F171 File Offset: 0x0001D371
			public unsafe Object _stateObject
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.SynchronousAsyncResult.NativeFieldInfoPtr__stateObject);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.SynchronousAsyncResult.NativeFieldInfoPtr__stateObject), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170014D5 RID: 5333
			// (get) Token: 0x06005186 RID: 20870 RVA: 0x0016C688 File Offset: 0x0016A888
			// (set) Token: 0x06005187 RID: 20871 RVA: 0x0001F190 File Offset: 0x0001D390
			public unsafe bool _isWrite
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.SynchronousAsyncResult.NativeFieldInfoPtr__isWrite);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.SynchronousAsyncResult.NativeFieldInfoPtr__isWrite)) = value;
				}
			}

			// Token: 0x170014D6 RID: 5334
			// (get) Token: 0x06005188 RID: 20872 RVA: 0x0016C6B0 File Offset: 0x0016A8B0
			// (set) Token: 0x06005189 RID: 20873 RVA: 0x0001F1AB File Offset: 0x0001D3AB
			public unsafe ManualResetEvent _waitHandle
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.SynchronousAsyncResult.NativeFieldInfoPtr__waitHandle);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManualResetEvent>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.SynchronousAsyncResult.NativeFieldInfoPtr__waitHandle), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170014D7 RID: 5335
			// (get) Token: 0x0600518A RID: 20874 RVA: 0x0016C6E0 File Offset: 0x0016A8E0
			// (set) Token: 0x0600518B RID: 20875 RVA: 0x0001F1CA File Offset: 0x0001D3CA
			public unsafe ExceptionDispatchInfo _exceptionInfo
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.SynchronousAsyncResult.NativeFieldInfoPtr__exceptionInfo);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ExceptionDispatchInfo>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.SynchronousAsyncResult.NativeFieldInfoPtr__exceptionInfo), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170014D8 RID: 5336
			// (get) Token: 0x0600518C RID: 20876 RVA: 0x0016C710 File Offset: 0x0016A910
			// (set) Token: 0x0600518D RID: 20877 RVA: 0x0001F1E9 File Offset: 0x0001D3E9
			public unsafe bool _endXxxCalled
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.SynchronousAsyncResult.NativeFieldInfoPtr__endXxxCalled);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.SynchronousAsyncResult.NativeFieldInfoPtr__endXxxCalled)) = value;
				}
			}

			// Token: 0x170014D9 RID: 5337
			// (get) Token: 0x0600518E RID: 20878 RVA: 0x0016C738 File Offset: 0x0016A938
			// (set) Token: 0x0600518F RID: 20879 RVA: 0x0001F204 File Offset: 0x0001D404
			public unsafe int _bytesRead
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.SynchronousAsyncResult.NativeFieldInfoPtr__bytesRead);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(Stream.SynchronousAsyncResult.NativeFieldInfoPtr__bytesRead)) = value;
				}
			}

			// Token: 0x040041FB RID: 16891
			private static readonly IntPtr NativeFieldInfoPtr__stateObject;

			// Token: 0x040041FC RID: 16892
			private static readonly IntPtr NativeFieldInfoPtr__isWrite;

			// Token: 0x040041FD RID: 16893
			private static readonly IntPtr NativeFieldInfoPtr__waitHandle;

			// Token: 0x040041FE RID: 16894
			private static readonly IntPtr NativeFieldInfoPtr__exceptionInfo;

			// Token: 0x040041FF RID: 16895
			private static readonly IntPtr NativeFieldInfoPtr__endXxxCalled;

			// Token: 0x04004200 RID: 16896
			private static readonly IntPtr NativeFieldInfoPtr__bytesRead;

			// Token: 0x04004201 RID: 16897
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Int32_Object_0;

			// Token: 0x04004202 RID: 16898
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Object_0;

			// Token: 0x04004203 RID: 16899
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Internal_Void_Exception_Object_Boolean_0;

			// Token: 0x04004204 RID: 16900
			private static readonly IntPtr NativeMethodInfoPtr_get_IsCompleted_Public_Virtual_Final_New_get_Boolean_0;

			// Token: 0x04004205 RID: 16901
			private static readonly IntPtr NativeMethodInfoPtr_get_AsyncWaitHandle_Public_Virtual_Final_New_get_WaitHandle_0;

			// Token: 0x04004206 RID: 16902
			private static readonly IntPtr NativeMethodInfoPtr_get_AsyncState_Public_Virtual_Final_New_get_Object_0;

			// Token: 0x04004207 RID: 16903
			private static readonly IntPtr NativeMethodInfoPtr_get_CompletedSynchronously_Public_Virtual_Final_New_get_Boolean_0;

			// Token: 0x04004208 RID: 16904
			private static readonly IntPtr NativeMethodInfoPtr_ThrowIfError_Internal_Void_0;

			// Token: 0x04004209 RID: 16905
			private static readonly IntPtr NativeMethodInfoPtr_EndRead_Internal_Static_Int32_IAsyncResult_0;

			// Token: 0x0400420A RID: 16906
			private static readonly IntPtr NativeMethodInfoPtr_EndWrite_Internal_Static_Void_IAsyncResult_0;

			// Token: 0x020006C5 RID: 1733
			[ObfuscatedName("System.IO.Stream+SynchronousAsyncResult+<>c")]
			[Serializable]
			public sealed class __c : Object
			{
				// Token: 0x060057D8 RID: 22488 RVA: 0x001806B8 File Offset: 0x0017E8B8
				// Note: this type is marked as 'beforefieldinit'.
				static __c()
				{
					Il2CppClassPointerStore<Stream.SynchronousAsyncResult.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Stream.SynchronousAsyncResult>.NativeClassPtr, "<>c");
					IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Stream.SynchronousAsyncResult.__c>.NativeClassPtr);
					Stream.SynchronousAsyncResult.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.SynchronousAsyncResult.__c>.NativeClassPtr, "<>9");
					Stream.SynchronousAsyncResult.__c.NativeFieldInfoPtr___9__12_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.SynchronousAsyncResult.__c>.NativeClassPtr, "<>9__12_0");
					Stream.SynchronousAsyncResult.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.SynchronousAsyncResult.__c>.NativeClassPtr, 100668892);
					Stream.SynchronousAsyncResult.__c.NativeMethodInfoPtr__get_AsyncWaitHandle_b__12_0_Internal_ManualResetEvent_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.SynchronousAsyncResult.__c>.NativeClassPtr, 100668893);
				}

				// Token: 0x060057D9 RID: 22489 RVA: 0x00180734 File Offset: 0x0017E934
				[CallerCount(817)]
				[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe __c()
					: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Stream.SynchronousAsyncResult.__c>.NativeClassPtr))
				{
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.SynchronousAsyncResult.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}

				// Token: 0x060057DA RID: 22490 RVA: 0x00180770 File Offset: 0x0017E970
				[CallerCount(0)]
				[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321248, XrefRangeEnd = 321252, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				public unsafe ManualResetEvent _get_AsyncWaitHandle_b__12_0()
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.SynchronousAsyncResult.__c.NativeMethodInfoPtr__get_AsyncWaitHandle_b__12_0_Internal_ManualResetEvent_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<ManualResetEvent>(intPtr3) : null;
				}

				// Token: 0x060057DB RID: 22491 RVA: 0x000226F2 File Offset: 0x000208F2
				public __c(IntPtr pointer)
					: base(pointer)
				{
				}

				// Token: 0x1700167D RID: 5757
				// (get) Token: 0x060057DC RID: 22492 RVA: 0x001807B0 File Offset: 0x0017E9B0
				// (set) Token: 0x060057DD RID: 22493 RVA: 0x000226FB File Offset: 0x000208FB
				public unsafe static Stream.SynchronousAsyncResult.__c __9
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(Stream.SynchronousAsyncResult.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream.SynchronousAsyncResult.__c>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Stream.SynchronousAsyncResult.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x1700167E RID: 5758
				// (get) Token: 0x060057DE RID: 22494 RVA: 0x001807D8 File Offset: 0x0017E9D8
				// (set) Token: 0x060057DF RID: 22495 RVA: 0x0002270D File Offset: 0x0002090D
				public unsafe static Func<ManualResetEvent> __9__12_0
				{
					get
					{
						IntPtr intPtr;
						IL2CPP.il2cpp_field_static_get_value(Stream.SynchronousAsyncResult.__c.NativeFieldInfoPtr___9__12_0, (void*)(&intPtr));
						IntPtr intPtr2 = intPtr;
						return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<ManualResetEvent>>(intPtr2) : null;
					}
					set
					{
						IL2CPP.il2cpp_field_static_set_value(Stream.SynchronousAsyncResult.__c.NativeFieldInfoPtr___9__12_0, IL2CPP.Il2CppObjectBaseToPtr(value));
					}
				}

				// Token: 0x0400461F RID: 17951
				private static readonly IntPtr NativeFieldInfoPtr___9;

				// Token: 0x04004620 RID: 17952
				private static readonly IntPtr NativeFieldInfoPtr___9__12_0;

				// Token: 0x04004621 RID: 17953
				private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

				// Token: 0x04004622 RID: 17954
				private static readonly IntPtr NativeMethodInfoPtr__get_AsyncWaitHandle_b__12_0_Internal_ManualResetEvent_0;
			}
		}

		// Token: 0x020005D2 RID: 1490
		[ObfuscatedName("System.IO.Stream+<>c")]
		[Serializable]
		public sealed class __c : Object
		{
			// Token: 0x06005190 RID: 20880 RVA: 0x0016C760 File Offset: 0x0016A960
			// Note: this type is marked as 'beforefieldinit'.
			static __c()
			{
				Il2CppClassPointerStore<Stream.__c>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<Stream>.NativeClassPtr, "<>c");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<Stream.__c>.NativeClassPtr);
				Stream.__c.NativeFieldInfoPtr___9 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.__c>.NativeClassPtr, "<>9");
				Stream.__c.NativeFieldInfoPtr___9__4_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.__c>.NativeClassPtr, "<>9__4_0");
				Stream.__c.NativeFieldInfoPtr___9__39_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.__c>.NativeClassPtr, "<>9__39_0");
				Stream.__c.NativeFieldInfoPtr___9__43_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.__c>.NativeClassPtr, "<>9__43_0");
				Stream.__c.NativeFieldInfoPtr___9__43_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.__c>.NativeClassPtr, "<>9__43_1");
				Stream.__c.NativeFieldInfoPtr___9__46_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.__c>.NativeClassPtr, "<>9__46_0");
				Stream.__c.NativeFieldInfoPtr___9__47_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.__c>.NativeClassPtr, "<>9__47_0");
				Stream.__c.NativeFieldInfoPtr___9__53_0 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.__c>.NativeClassPtr, "<>9__53_0");
				Stream.__c.NativeFieldInfoPtr___9__53_1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<Stream.__c>.NativeClassPtr, "<>9__53_1");
				Stream.__c.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.__c>.NativeClassPtr, 100668895);
				Stream.__c.NativeMethodInfoPtr__EnsureAsyncActiveSemaphoreInitialized_b__4_0_Internal_SemaphoreSlim_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.__c>.NativeClassPtr, 100668896);
				Stream.__c.NativeMethodInfoPtr__BeginReadInternal_b__39_0_Internal_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.__c>.NativeClassPtr, 100668897);
				Stream.__c.NativeMethodInfoPtr__BeginEndReadAsync_b__43_0_Internal_IAsyncResult_Stream_ReadWriteParameters_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.__c>.NativeClassPtr, 100668898);
				Stream.__c.NativeMethodInfoPtr__BeginEndReadAsync_b__43_1_Internal_Int32_Stream_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.__c>.NativeClassPtr, 100668899);
				Stream.__c.NativeMethodInfoPtr__BeginWriteInternal_b__46_0_Internal_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.__c>.NativeClassPtr, 100668900);
				Stream.__c.NativeMethodInfoPtr__RunReadWriteTaskWhenReady_b__47_0_Internal_Void_Task_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.__c>.NativeClassPtr, 100668901);
				Stream.__c.NativeMethodInfoPtr__BeginEndWriteAsync_b__53_0_Internal_IAsyncResult_Stream_ReadWriteParameters_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.__c>.NativeClassPtr, 100668902);
				Stream.__c.NativeMethodInfoPtr__BeginEndWriteAsync_b__53_1_Internal_VoidTaskResult_Stream_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<Stream.__c>.NativeClassPtr, 100668903);
			}

			// Token: 0x06005191 RID: 20881 RVA: 0x0016C8F4 File Offset: 0x0016AAF4
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<Stream.__c>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.__c.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005192 RID: 20882 RVA: 0x0016C930 File Offset: 0x0016AB30
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321292, XrefRangeEnd = 321296, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SemaphoreSlim _EnsureAsyncActiveSemaphoreInitialized_b__4_0()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.__c.NativeMethodInfoPtr__EnsureAsyncActiveSemaphoreInitialized_b__4_0_Internal_SemaphoreSlim_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<SemaphoreSlim>(intPtr3) : null;
			}

			// Token: 0x06005193 RID: 20883 RVA: 0x0016C970 File Offset: 0x0016AB70
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321296, XrefRangeEnd = 321307, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _BeginReadInternal_b__39_0(Object <p0>)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.__c.NativeMethodInfoPtr__BeginReadInternal_b__39_0_Internal_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005194 RID: 20884 RVA: 0x0016C9C0 File Offset: 0x0016ABC0
			[CallerCount(0)]
			public unsafe IAsyncResult _BeginEndReadAsync_b__43_0(Stream stream, Stream.ReadWriteParameters args, AsyncCallback callback, Object state)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(args));
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.__c.NativeMethodInfoPtr__BeginEndReadAsync_b__43_0_Internal_IAsyncResult_Stream_ReadWriteParameters_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06005195 RID: 20885 RVA: 0x0016CA4C File Offset: 0x0016AC4C
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321307, XrefRangeEnd = 321308, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _BeginEndReadAsync_b__43_1(Stream stream, IAsyncResult asyncResult)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.__c.NativeMethodInfoPtr__BeginEndReadAsync_b__43_1_Internal_Int32_Stream_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x06005196 RID: 20886 RVA: 0x0016CAAC File Offset: 0x0016ACAC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321308, XrefRangeEnd = 321319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe int _BeginWriteInternal_b__46_0(Object <p0>)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(<p0>);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.__c.NativeMethodInfoPtr__BeginWriteInternal_b__46_0_Internal_Int32_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					return *IL2CPP.il2cpp_object_unbox(intPtr);
				}
			}

			// Token: 0x06005197 RID: 20887 RVA: 0x0016CAFC File Offset: 0x0016ACFC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 321319, XrefRangeEnd = 321326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _RunReadWriteTaskWhenReady_b__47_0(Task t, Object state)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(t);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.__c.NativeMethodInfoPtr__RunReadWriteTaskWhenReady_b__47_0_Internal_Void_Task_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06005198 RID: 20888 RVA: 0x0016CB50 File Offset: 0x0016AD50
			[CallerCount(0)]
			public unsafe IAsyncResult _BeginEndWriteAsync_b__53_0(Stream stream, Stream.ReadWriteParameters args, AsyncCallback callback, Object state)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(args));
				ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(callback);
				ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.__c.NativeMethodInfoPtr__BeginEndWriteAsync_b__53_0_Internal_IAsyncResult_Stream_ReadWriteParameters_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IAsyncResult>(intPtr3) : null;
			}

			// Token: 0x06005199 RID: 20889 RVA: 0x0016CBDC File Offset: 0x0016ADDC
			[CallerCount(0)]
			public unsafe VoidTaskResult _BeginEndWriteAsync_b__53_1(Stream stream, IAsyncResult asyncResult)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(stream);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(asyncResult);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(Stream.__c.NativeMethodInfoPtr__BeginEndWriteAsync_b__53_1_Internal_VoidTaskResult_Stream_IAsyncResult_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x0600519A RID: 20890 RVA: 0x0001F21F File Offset: 0x0001D41F
			public __c(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170014DE RID: 5342
			// (get) Token: 0x0600519B RID: 20891 RVA: 0x0016CC3C File Offset: 0x0016AE3C
			// (set) Token: 0x0600519C RID: 20892 RVA: 0x0001F228 File Offset: 0x0001D428
			public unsafe static Stream.__c __9
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Stream.__c.NativeFieldInfoPtr___9, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Stream.__c>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Stream.__c.NativeFieldInfoPtr___9, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170014DF RID: 5343
			// (get) Token: 0x0600519D RID: 20893 RVA: 0x0016CC64 File Offset: 0x0016AE64
			// (set) Token: 0x0600519E RID: 20894 RVA: 0x0001F23A File Offset: 0x0001D43A
			public unsafe static Func<SemaphoreSlim> __9__4_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Stream.__c.NativeFieldInfoPtr___9__4_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<SemaphoreSlim>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Stream.__c.NativeFieldInfoPtr___9__4_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170014E0 RID: 5344
			// (get) Token: 0x0600519F RID: 20895 RVA: 0x0016CC8C File Offset: 0x0016AE8C
			// (set) Token: 0x060051A0 RID: 20896 RVA: 0x0001F24C File Offset: 0x0001D44C
			public unsafe static Func<Object, int> __9__39_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Stream.__c.NativeFieldInfoPtr___9__39_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Object, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Stream.__c.NativeFieldInfoPtr___9__39_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170014E1 RID: 5345
			// (get) Token: 0x060051A1 RID: 20897 RVA: 0x0016CCB4 File Offset: 0x0016AEB4
			// (set) Token: 0x060051A2 RID: 20898 RVA: 0x0001F25E File Offset: 0x0001D45E
			public unsafe static Func<Stream, Stream.ReadWriteParameters, AsyncCallback, Object, IAsyncResult> __9__43_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Stream.__c.NativeFieldInfoPtr___9__43_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Stream, Stream.ReadWriteParameters, AsyncCallback, Object, IAsyncResult>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Stream.__c.NativeFieldInfoPtr___9__43_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170014E2 RID: 5346
			// (get) Token: 0x060051A3 RID: 20899 RVA: 0x0016CCDC File Offset: 0x0016AEDC
			// (set) Token: 0x060051A4 RID: 20900 RVA: 0x0001F270 File Offset: 0x0001D470
			public unsafe static Func<Stream, IAsyncResult, int> __9__43_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Stream.__c.NativeFieldInfoPtr___9__43_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Stream, IAsyncResult, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Stream.__c.NativeFieldInfoPtr___9__43_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170014E3 RID: 5347
			// (get) Token: 0x060051A5 RID: 20901 RVA: 0x0016CD04 File Offset: 0x0016AF04
			// (set) Token: 0x060051A6 RID: 20902 RVA: 0x0001F282 File Offset: 0x0001D482
			public unsafe static Func<Object, int> __9__46_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Stream.__c.NativeFieldInfoPtr___9__46_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Object, int>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Stream.__c.NativeFieldInfoPtr___9__46_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170014E4 RID: 5348
			// (get) Token: 0x060051A7 RID: 20903 RVA: 0x0016CD2C File Offset: 0x0016AF2C
			// (set) Token: 0x060051A8 RID: 20904 RVA: 0x0001F294 File Offset: 0x0001D494
			public unsafe static Action<Task, Object> __9__47_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Stream.__c.NativeFieldInfoPtr___9__47_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<Task, Object>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Stream.__c.NativeFieldInfoPtr___9__47_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170014E5 RID: 5349
			// (get) Token: 0x060051A9 RID: 20905 RVA: 0x0016CD54 File Offset: 0x0016AF54
			// (set) Token: 0x060051AA RID: 20906 RVA: 0x0001F2A6 File Offset: 0x0001D4A6
			public unsafe static Func<Stream, Stream.ReadWriteParameters, AsyncCallback, Object, IAsyncResult> __9__53_0
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Stream.__c.NativeFieldInfoPtr___9__53_0, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Stream, Stream.ReadWriteParameters, AsyncCallback, Object, IAsyncResult>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Stream.__c.NativeFieldInfoPtr___9__53_0, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170014E6 RID: 5350
			// (get) Token: 0x060051AB RID: 20907 RVA: 0x0016CD7C File Offset: 0x0016AF7C
			// (set) Token: 0x060051AC RID: 20908 RVA: 0x0001F2B8 File Offset: 0x0001D4B8
			public unsafe static Func<Stream, IAsyncResult, VoidTaskResult> __9__53_1
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(Stream.__c.NativeFieldInfoPtr___9__53_1, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Func<Stream, IAsyncResult, VoidTaskResult>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(Stream.__c.NativeFieldInfoPtr___9__53_1, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400420B RID: 16907
			private static readonly IntPtr NativeFieldInfoPtr___9;

			// Token: 0x0400420C RID: 16908
			private static readonly IntPtr NativeFieldInfoPtr___9__4_0;

			// Token: 0x0400420D RID: 16909
			private static readonly IntPtr NativeFieldInfoPtr___9__39_0;

			// Token: 0x0400420E RID: 16910
			private static readonly IntPtr NativeFieldInfoPtr___9__43_0;

			// Token: 0x0400420F RID: 16911
			private static readonly IntPtr NativeFieldInfoPtr___9__43_1;

			// Token: 0x04004210 RID: 16912
			private static readonly IntPtr NativeFieldInfoPtr___9__46_0;

			// Token: 0x04004211 RID: 16913
			private static readonly IntPtr NativeFieldInfoPtr___9__47_0;

			// Token: 0x04004212 RID: 16914
			private static readonly IntPtr NativeFieldInfoPtr___9__53_0;

			// Token: 0x04004213 RID: 16915
			private static readonly IntPtr NativeFieldInfoPtr___9__53_1;

			// Token: 0x04004214 RID: 16916
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04004215 RID: 16917
			private static readonly IntPtr NativeMethodInfoPtr__EnsureAsyncActiveSemaphoreInitialized_b__4_0_Internal_SemaphoreSlim_0;

			// Token: 0x04004216 RID: 16918
			private static readonly IntPtr NativeMethodInfoPtr__BeginReadInternal_b__39_0_Internal_Int32_Object_0;

			// Token: 0x04004217 RID: 16919
			private static readonly IntPtr NativeMethodInfoPtr__BeginEndReadAsync_b__43_0_Internal_IAsyncResult_Stream_ReadWriteParameters_AsyncCallback_Object_0;

			// Token: 0x04004218 RID: 16920
			private static readonly IntPtr NativeMethodInfoPtr__BeginEndReadAsync_b__43_1_Internal_Int32_Stream_IAsyncResult_0;

			// Token: 0x04004219 RID: 16921
			private static readonly IntPtr NativeMethodInfoPtr__BeginWriteInternal_b__46_0_Internal_Int32_Object_0;

			// Token: 0x0400421A RID: 16922
			private static readonly IntPtr NativeMethodInfoPtr__RunReadWriteTaskWhenReady_b__47_0_Internal_Void_Task_Object_0;

			// Token: 0x0400421B RID: 16923
			private static readonly IntPtr NativeMethodInfoPtr__BeginEndWriteAsync_b__53_0_Internal_IAsyncResult_Stream_ReadWriteParameters_AsyncCallback_Object_0;

			// Token: 0x0400421C RID: 16924
			private static readonly IntPtr NativeMethodInfoPtr__BeginEndWriteAsync_b__53_1_Internal_VoidTaskResult_Stream_IAsyncResult_0;
		}
	}
}
