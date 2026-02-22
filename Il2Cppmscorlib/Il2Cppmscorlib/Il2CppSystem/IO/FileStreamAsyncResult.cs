using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Threading;

namespace Il2CppSystem.IO
{
	// Token: 0x0200021A RID: 538
	public class FileStreamAsyncResult : Object
	{
		// Token: 0x060022F7 RID: 8951 RVA: 0x000BF584 File Offset: 0x000BD784
		// Note: this type is marked as 'beforefieldinit'.
		static FileStreamAsyncResult()
		{
			Il2CppClassPointerStore<FileStreamAsyncResult>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.IO", "FileStreamAsyncResult");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<FileStreamAsyncResult>.NativeClassPtr);
			FileStreamAsyncResult.NativeFieldInfoPtr_state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileStreamAsyncResult>.NativeClassPtr, "state");
			FileStreamAsyncResult.NativeFieldInfoPtr_completed = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileStreamAsyncResult>.NativeClassPtr, "completed");
			FileStreamAsyncResult.NativeFieldInfoPtr_wh = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileStreamAsyncResult>.NativeClassPtr, "wh");
			FileStreamAsyncResult.NativeFieldInfoPtr_cb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileStreamAsyncResult>.NativeClassPtr, "cb");
			FileStreamAsyncResult.NativeFieldInfoPtr_completedSynch = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileStreamAsyncResult>.NativeClassPtr, "completedSynch");
			FileStreamAsyncResult.NativeFieldInfoPtr_Count = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileStreamAsyncResult>.NativeClassPtr, "Count");
			FileStreamAsyncResult.NativeFieldInfoPtr_OriginalCount = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileStreamAsyncResult>.NativeClassPtr, "OriginalCount");
			FileStreamAsyncResult.NativeFieldInfoPtr_BytesRead = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileStreamAsyncResult>.NativeClassPtr, "BytesRead");
			FileStreamAsyncResult.NativeFieldInfoPtr_realcb = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<FileStreamAsyncResult>.NativeClassPtr, "realcb");
			FileStreamAsyncResult.NativeMethodInfoPtr__ctor_Public_Void_AsyncCallback_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStreamAsyncResult>.NativeClassPtr, 100669160);
			FileStreamAsyncResult.NativeMethodInfoPtr_CBWrapper_Private_Static_Void_IAsyncResult_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStreamAsyncResult>.NativeClassPtr, 100669161);
			FileStreamAsyncResult.NativeMethodInfoPtr_get_AsyncState_Public_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStreamAsyncResult>.NativeClassPtr, 100669162);
			FileStreamAsyncResult.NativeMethodInfoPtr_get_CompletedSynchronously_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStreamAsyncResult>.NativeClassPtr, 100669163);
			FileStreamAsyncResult.NativeMethodInfoPtr_get_AsyncWaitHandle_Public_Virtual_Final_New_get_WaitHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStreamAsyncResult>.NativeClassPtr, 100669164);
			FileStreamAsyncResult.NativeMethodInfoPtr_get_IsCompleted_Public_Virtual_Final_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<FileStreamAsyncResult>.NativeClassPtr, 100669165);
		}

		// Token: 0x060022F8 RID: 8952 RVA: 0x000BF6E0 File Offset: 0x000BD8E0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323185, XrefRangeEnd = 323196, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe FileStreamAsyncResult(AsyncCallback cb, Object state)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<FileStreamAsyncResult>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(cb);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(state);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileStreamAsyncResult.NativeMethodInfoPtr__ctor_Public_Void_AsyncCallback_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060022F9 RID: 8953 RVA: 0x000BF740 File Offset: 0x000BD940
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 323196, XrefRangeEnd = 323199, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void CBWrapper(IAsyncResult ares)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ares);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileStreamAsyncResult.NativeMethodInfoPtr_CBWrapper_Private_Static_Void_IAsyncResult_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000767 RID: 1895
		// (get) Token: 0x060022FA RID: 8954 RVA: 0x000BF778 File Offset: 0x000BD978
		public unsafe virtual Object AsyncState
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileStreamAsyncResult.NativeMethodInfoPtr_get_AsyncState_Public_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x17000768 RID: 1896
		// (get) Token: 0x060022FB RID: 8955 RVA: 0x000BF7B8 File Offset: 0x000BD9B8
		public unsafe virtual bool CompletedSynchronously
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileStreamAsyncResult.NativeMethodInfoPtr_get_CompletedSynchronously_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000769 RID: 1897
		// (get) Token: 0x060022FC RID: 8956 RVA: 0x000BF7F4 File Offset: 0x000BD9F4
		public unsafe virtual WaitHandle AsyncWaitHandle
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 5350, RefRangeEnd = 5351, XrefRangeStart = 5350, XrefRangeEnd = 5351, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileStreamAsyncResult.NativeMethodInfoPtr_get_AsyncWaitHandle_Public_Virtual_Final_New_get_WaitHandle_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<WaitHandle>(intPtr3) : null;
			}
		}

		// Token: 0x1700076A RID: 1898
		// (get) Token: 0x060022FD RID: 8957 RVA: 0x000BF834 File Offset: 0x000BDA34
		public unsafe virtual bool IsCompleted
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(FileStreamAsyncResult.NativeMethodInfoPtr_get_IsCompleted_Public_Virtual_Final_New_get_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060022FE RID: 8958 RVA: 0x0000BD6F File Offset: 0x00009F6F
		public FileStreamAsyncResult(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700075E RID: 1886
		// (get) Token: 0x060022FF RID: 8959 RVA: 0x000BF870 File Offset: 0x000BDA70
		// (set) Token: 0x06002300 RID: 8960 RVA: 0x0000BD78 File Offset: 0x00009F78
		public unsafe Object state
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStreamAsyncResult.NativeFieldInfoPtr_state);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStreamAsyncResult.NativeFieldInfoPtr_state), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700075F RID: 1887
		// (get) Token: 0x06002301 RID: 8961 RVA: 0x000BF8A0 File Offset: 0x000BDAA0
		// (set) Token: 0x06002302 RID: 8962 RVA: 0x0000BD97 File Offset: 0x00009F97
		public unsafe bool completed
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStreamAsyncResult.NativeFieldInfoPtr_completed);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStreamAsyncResult.NativeFieldInfoPtr_completed)) = value;
			}
		}

		// Token: 0x17000760 RID: 1888
		// (get) Token: 0x06002303 RID: 8963 RVA: 0x000BF8C8 File Offset: 0x000BDAC8
		// (set) Token: 0x06002304 RID: 8964 RVA: 0x0000BDB2 File Offset: 0x00009FB2
		public unsafe ManualResetEvent wh
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStreamAsyncResult.NativeFieldInfoPtr_wh);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ManualResetEvent>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStreamAsyncResult.NativeFieldInfoPtr_wh), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000761 RID: 1889
		// (get) Token: 0x06002305 RID: 8965 RVA: 0x000BF8F8 File Offset: 0x000BDAF8
		// (set) Token: 0x06002306 RID: 8966 RVA: 0x0000BDD1 File Offset: 0x00009FD1
		public unsafe AsyncCallback cb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStreamAsyncResult.NativeFieldInfoPtr_cb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStreamAsyncResult.NativeFieldInfoPtr_cb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000762 RID: 1890
		// (get) Token: 0x06002307 RID: 8967 RVA: 0x000BF928 File Offset: 0x000BDB28
		// (set) Token: 0x06002308 RID: 8968 RVA: 0x0000BDF0 File Offset: 0x00009FF0
		public unsafe bool completedSynch
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStreamAsyncResult.NativeFieldInfoPtr_completedSynch);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStreamAsyncResult.NativeFieldInfoPtr_completedSynch)) = value;
			}
		}

		// Token: 0x17000763 RID: 1891
		// (get) Token: 0x06002309 RID: 8969 RVA: 0x000BF950 File Offset: 0x000BDB50
		// (set) Token: 0x0600230A RID: 8970 RVA: 0x0000BE0B File Offset: 0x0000A00B
		public unsafe int Count
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStreamAsyncResult.NativeFieldInfoPtr_Count);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStreamAsyncResult.NativeFieldInfoPtr_Count)) = value;
			}
		}

		// Token: 0x17000764 RID: 1892
		// (get) Token: 0x0600230B RID: 8971 RVA: 0x000BF978 File Offset: 0x000BDB78
		// (set) Token: 0x0600230C RID: 8972 RVA: 0x0000BE26 File Offset: 0x0000A026
		public unsafe int OriginalCount
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStreamAsyncResult.NativeFieldInfoPtr_OriginalCount);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStreamAsyncResult.NativeFieldInfoPtr_OriginalCount)) = value;
			}
		}

		// Token: 0x17000765 RID: 1893
		// (get) Token: 0x0600230D RID: 8973 RVA: 0x000BF9A0 File Offset: 0x000BDBA0
		// (set) Token: 0x0600230E RID: 8974 RVA: 0x0000BE41 File Offset: 0x0000A041
		public unsafe int BytesRead
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStreamAsyncResult.NativeFieldInfoPtr_BytesRead);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStreamAsyncResult.NativeFieldInfoPtr_BytesRead)) = value;
			}
		}

		// Token: 0x17000766 RID: 1894
		// (get) Token: 0x0600230F RID: 8975 RVA: 0x000BF9C8 File Offset: 0x000BDBC8
		// (set) Token: 0x06002310 RID: 8976 RVA: 0x0000BE5C File Offset: 0x0000A05C
		public unsafe AsyncCallback realcb
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStreamAsyncResult.NativeFieldInfoPtr_realcb);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<AsyncCallback>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(FileStreamAsyncResult.NativeFieldInfoPtr_realcb), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04001F4D RID: 8013
		private static readonly IntPtr NativeFieldInfoPtr_state;

		// Token: 0x04001F4E RID: 8014
		private static readonly IntPtr NativeFieldInfoPtr_completed;

		// Token: 0x04001F4F RID: 8015
		private static readonly IntPtr NativeFieldInfoPtr_wh;

		// Token: 0x04001F50 RID: 8016
		private static readonly IntPtr NativeFieldInfoPtr_cb;

		// Token: 0x04001F51 RID: 8017
		private static readonly IntPtr NativeFieldInfoPtr_completedSynch;

		// Token: 0x04001F52 RID: 8018
		private static readonly IntPtr NativeFieldInfoPtr_Count;

		// Token: 0x04001F53 RID: 8019
		private static readonly IntPtr NativeFieldInfoPtr_OriginalCount;

		// Token: 0x04001F54 RID: 8020
		private static readonly IntPtr NativeFieldInfoPtr_BytesRead;

		// Token: 0x04001F55 RID: 8021
		private static readonly IntPtr NativeFieldInfoPtr_realcb;

		// Token: 0x04001F56 RID: 8022
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_AsyncCallback_Object_0;

		// Token: 0x04001F57 RID: 8023
		private static readonly IntPtr NativeMethodInfoPtr_CBWrapper_Private_Static_Void_IAsyncResult_0;

		// Token: 0x04001F58 RID: 8024
		private static readonly IntPtr NativeMethodInfoPtr_get_AsyncState_Public_Virtual_Final_New_get_Object_0;

		// Token: 0x04001F59 RID: 8025
		private static readonly IntPtr NativeMethodInfoPtr_get_CompletedSynchronously_Public_Virtual_Final_New_get_Boolean_0;

		// Token: 0x04001F5A RID: 8026
		private static readonly IntPtr NativeMethodInfoPtr_get_AsyncWaitHandle_Public_Virtual_Final_New_get_WaitHandle_0;

		// Token: 0x04001F5B RID: 8027
		private static readonly IntPtr NativeMethodInfoPtr_get_IsCompleted_Public_Virtual_Final_New_get_Boolean_0;
	}
}
