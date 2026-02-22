using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine.Networking;

namespace UnityEngine.Purchasing
{
	// Token: 0x02000062 RID: 98
	public class AsyncWebUtil : MonoBehaviour
	{
		// Token: 0x0600038B RID: 907 RVA: 0x000118D8 File Offset: 0x0000FAD8
		// Note: this type is marked as 'beforefieldinit'.
		static AsyncWebUtil()
		{
			Il2CppClassPointerStore<AsyncWebUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "UnityEngine.Purchasing", "AsyncWebUtil");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncWebUtil>.NativeClassPtr);
			AsyncWebUtil.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_String_Action_1_String_Action_1_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncWebUtil>.NativeClassPtr, 100663731);
			AsyncWebUtil.NativeMethodInfoPtr_Post_Public_Virtual_Final_New_Void_String_String_Action_1_String_Action_1_String_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncWebUtil>.NativeClassPtr, 100663732);
			AsyncWebUtil.NativeMethodInfoPtr_CreateGenericWebOperation_Private_Action_1_AsyncOperation_UnityWebRequest_Action_1_String_Action_1_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncWebUtil>.NativeClassPtr, 100663733);
			AsyncWebUtil.NativeMethodInfoPtr_Schedule_Public_Virtual_Final_New_Void_Action_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncWebUtil>.NativeClassPtr, 100663734);
			AsyncWebUtil.NativeMethodInfoPtr_DoInvoke_Private_IEnumerator_Action_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncWebUtil>.NativeClassPtr, 100663735);
			AsyncWebUtil.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncWebUtil>.NativeClassPtr, 100663736);
		}

		// Token: 0x0600038C RID: 908 RVA: 0x00011980 File Offset: 0x0000FB80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154886, XrefRangeEnd = 154892, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Get(string url, Action<string> responseHandler, Action<string> errorHandler, int maxTimeoutInSeconds = 5)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(responseHandler);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(errorHandler);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxTimeoutInSeconds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncWebUtil.NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_String_Action_1_String_Action_1_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600038D RID: 909 RVA: 0x000119F4 File Offset: 0x0000FBF4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154892, XrefRangeEnd = 154898, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Post(string url, string body, Action<string> responseHandler, Action<string> errorHandler, int maxTimeoutInSeconds = 5)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)5) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.ManagedStringToIl2Cpp(url);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.ManagedStringToIl2Cpp(body);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(responseHandler);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(errorHandler);
			ptr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref maxTimeoutInSeconds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncWebUtil.NativeMethodInfoPtr_Post_Public_Virtual_Final_New_Void_String_String_Action_1_String_Action_1_String_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600038E RID: 910 RVA: 0x00011A7C File Offset: 0x0000FC7C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 154910, RefRangeEnd = 154912, XrefRangeStart = 154898, XrefRangeEnd = 154910, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Action<AsyncOperation> CreateGenericWebOperation(UnityWebRequest request, Action<string> responseHandler, Action<string> errorHandler)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(request);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(responseHandler);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(errorHandler);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncWebUtil.NativeMethodInfoPtr_CreateGenericWebOperation_Private_Action_1_AsyncOperation_UnityWebRequest_Action_1_String_Action_1_String_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Action<AsyncOperation>>(intPtr3) : null;
		}

		// Token: 0x0600038F RID: 911 RVA: 0x00011AF0 File Offset: 0x0000FCF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154912, XrefRangeEnd = 154917, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Schedule(Action a, int delayInSeconds)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delayInSeconds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncWebUtil.NativeMethodInfoPtr_Schedule_Public_Virtual_Final_New_Void_Action_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000390 RID: 912 RVA: 0x00011B40 File Offset: 0x0000FD40
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154917, XrefRangeEnd = 154921, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IEnumerator DoInvoke(Action a, int delayInSeconds)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(a);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delayInSeconds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncWebUtil.NativeMethodInfoPtr_DoInvoke_Private_IEnumerator_Action_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IEnumerator>(intPtr3) : null;
		}

		// Token: 0x06000391 RID: 913 RVA: 0x00011BA0 File Offset: 0x0000FDA0
		[CallerCount(53)]
		[CachedScanResults(RefRangeStart = 77782, RefRangeEnd = 77835, XrefRangeStart = 77782, XrefRangeEnd = 77835, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncWebUtil()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncWebUtil>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncWebUtil.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000392 RID: 914 RVA: 0x00003CB4 File Offset: 0x00001EB4
		public AsyncWebUtil(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x0400022C RID: 556
		private static readonly IntPtr NativeMethodInfoPtr_Get_Public_Virtual_Final_New_Void_String_Action_1_String_Action_1_String_Int32_0;

		// Token: 0x0400022D RID: 557
		private static readonly IntPtr NativeMethodInfoPtr_Post_Public_Virtual_Final_New_Void_String_String_Action_1_String_Action_1_String_Int32_0;

		// Token: 0x0400022E RID: 558
		private static readonly IntPtr NativeMethodInfoPtr_CreateGenericWebOperation_Private_Action_1_AsyncOperation_UnityWebRequest_Action_1_String_Action_1_String_0;

		// Token: 0x0400022F RID: 559
		private static readonly IntPtr NativeMethodInfoPtr_Schedule_Public_Virtual_Final_New_Void_Action_Int32_0;

		// Token: 0x04000230 RID: 560
		private static readonly IntPtr NativeMethodInfoPtr_DoInvoke_Private_IEnumerator_Action_Int32_0;

		// Token: 0x04000231 RID: 561
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x020000BE RID: 190
		[ObfuscatedName("UnityEngine.Purchasing.AsyncWebUtil+<>c__DisplayClass2_0")]
		public sealed class __c__DisplayClass2_0 : Object
		{
			// Token: 0x060006EA RID: 1770 RVA: 0x0001C324 File Offset: 0x0001A524
			// Note: this type is marked as 'beforefieldinit'.
			static __c__DisplayClass2_0()
			{
				Il2CppClassPointerStore<AsyncWebUtil.__c__DisplayClass2_0>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AsyncWebUtil>.NativeClassPtr, "<>c__DisplayClass2_0");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncWebUtil.__c__DisplayClass2_0>.NativeClassPtr);
				AsyncWebUtil.__c__DisplayClass2_0.NativeFieldInfoPtr_request = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncWebUtil.__c__DisplayClass2_0>.NativeClassPtr, "request");
				AsyncWebUtil.__c__DisplayClass2_0.NativeFieldInfoPtr_errorHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncWebUtil.__c__DisplayClass2_0>.NativeClassPtr, "errorHandler");
				AsyncWebUtil.__c__DisplayClass2_0.NativeFieldInfoPtr_responseHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncWebUtil.__c__DisplayClass2_0>.NativeClassPtr, "responseHandler");
				AsyncWebUtil.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncWebUtil.__c__DisplayClass2_0>.NativeClassPtr, 100663737);
				AsyncWebUtil.__c__DisplayClass2_0.NativeMethodInfoPtr__CreateGenericWebOperation_b__0_Internal_Void_AsyncOperation_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncWebUtil.__c__DisplayClass2_0>.NativeClassPtr, 100663738);
			}

			// Token: 0x060006EB RID: 1771 RVA: 0x0001C3B4 File Offset: 0x0001A5B4
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe __c__DisplayClass2_0()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncWebUtil.__c__DisplayClass2_0>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncWebUtil.__c__DisplayClass2_0.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060006EC RID: 1772 RVA: 0x0001C3F0 File Offset: 0x0001A5F0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154865, XrefRangeEnd = 154877, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void _CreateGenericWebOperation_b__0(AsyncOperation op)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(op);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncWebUtil.__c__DisplayClass2_0.NativeMethodInfoPtr__CreateGenericWebOperation_b__0_Internal_Void_AsyncOperation_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060006ED RID: 1773 RVA: 0x000057D8 File Offset: 0x000039D8
			public __c__DisplayClass2_0(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170001BE RID: 446
			// (get) Token: 0x060006EE RID: 1774 RVA: 0x0001C434 File Offset: 0x0001A634
			// (set) Token: 0x060006EF RID: 1775 RVA: 0x000057E1 File Offset: 0x000039E1
			public unsafe UnityWebRequest request
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncWebUtil.__c__DisplayClass2_0.NativeFieldInfoPtr_request);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityWebRequest>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncWebUtil.__c__DisplayClass2_0.NativeFieldInfoPtr_request), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001BF RID: 447
			// (get) Token: 0x060006F0 RID: 1776 RVA: 0x0001C464 File Offset: 0x0001A664
			// (set) Token: 0x060006F1 RID: 1777 RVA: 0x00005800 File Offset: 0x00003A00
			public unsafe Action<string> errorHandler
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncWebUtil.__c__DisplayClass2_0.NativeFieldInfoPtr_errorHandler);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncWebUtil.__c__DisplayClass2_0.NativeFieldInfoPtr_errorHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001C0 RID: 448
			// (get) Token: 0x060006F2 RID: 1778 RVA: 0x0001C494 File Offset: 0x0001A694
			// (set) Token: 0x060006F3 RID: 1779 RVA: 0x0000581F File Offset: 0x00003A1F
			public unsafe Action<string> responseHandler
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncWebUtil.__c__DisplayClass2_0.NativeFieldInfoPtr_responseHandler);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<string>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncWebUtil.__c__DisplayClass2_0.NativeFieldInfoPtr_responseHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400047D RID: 1149
			private static readonly IntPtr NativeFieldInfoPtr_request;

			// Token: 0x0400047E RID: 1150
			private static readonly IntPtr NativeFieldInfoPtr_errorHandler;

			// Token: 0x0400047F RID: 1151
			private static readonly IntPtr NativeFieldInfoPtr_responseHandler;

			// Token: 0x04000480 RID: 1152
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

			// Token: 0x04000481 RID: 1153
			private static readonly IntPtr NativeMethodInfoPtr__CreateGenericWebOperation_b__0_Internal_Void_AsyncOperation_0;
		}

		// Token: 0x020000BF RID: 191
		[ObfuscatedName("UnityEngine.Purchasing.AsyncWebUtil+<DoInvoke>d__4")]
		public sealed class _DoInvoke_d__4 : Object
		{
			// Token: 0x060006F4 RID: 1780 RVA: 0x0001C4C4 File Offset: 0x0001A6C4
			// Note: this type is marked as 'beforefieldinit'.
			static _DoInvoke_d__4()
			{
				Il2CppClassPointerStore<AsyncWebUtil._DoInvoke_d__4>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<AsyncWebUtil>.NativeClassPtr, "<DoInvoke>d__4");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncWebUtil._DoInvoke_d__4>.NativeClassPtr);
				AsyncWebUtil._DoInvoke_d__4.NativeFieldInfoPtr___1__state = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncWebUtil._DoInvoke_d__4>.NativeClassPtr, "<>1__state");
				AsyncWebUtil._DoInvoke_d__4.NativeFieldInfoPtr___2__current = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncWebUtil._DoInvoke_d__4>.NativeClassPtr, "<>2__current");
				AsyncWebUtil._DoInvoke_d__4.NativeFieldInfoPtr_delayInSeconds = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncWebUtil._DoInvoke_d__4>.NativeClassPtr, "delayInSeconds");
				AsyncWebUtil._DoInvoke_d__4.NativeFieldInfoPtr_a = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncWebUtil._DoInvoke_d__4>.NativeClassPtr, "a");
				AsyncWebUtil._DoInvoke_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncWebUtil._DoInvoke_d__4>.NativeClassPtr, 100663739);
				AsyncWebUtil._DoInvoke_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncWebUtil._DoInvoke_d__4>.NativeClassPtr, 100663740);
				AsyncWebUtil._DoInvoke_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncWebUtil._DoInvoke_d__4>.NativeClassPtr, 100663741);
				AsyncWebUtil._DoInvoke_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncWebUtil._DoInvoke_d__4>.NativeClassPtr, 100663742);
				AsyncWebUtil._DoInvoke_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncWebUtil._DoInvoke_d__4>.NativeClassPtr, 100663743);
				AsyncWebUtil._DoInvoke_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncWebUtil._DoInvoke_d__4>.NativeClassPtr, 100663744);
			}

			// Token: 0x060006F5 RID: 1781 RVA: 0x0001C5B8 File Offset: 0x0001A7B8
			[CallerCount(208)]
			[CachedScanResults(RefRangeStart = 8591, RefRangeEnd = 8799, XrefRangeStart = 8591, XrefRangeEnd = 8799, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe _DoInvoke_d__4(int <>1__state)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncWebUtil._DoInvoke_d__4>.NativeClassPtr))
			{
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref <>1__state;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncWebUtil._DoInvoke_d__4.NativeMethodInfoPtr__ctor_Public_Void_Int32_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060006F6 RID: 1782 RVA: 0x0001C600 File Offset: 0x0001A800
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_IDisposable_Dispose()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncWebUtil._DoInvoke_d__4.NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060006F7 RID: 1783 RVA: 0x0001C634 File Offset: 0x0001A834
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154877, XrefRangeEnd = 154881, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe bool MoveNext()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncWebUtil._DoInvoke_d__4.NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}

			// Token: 0x170001C5 RID: 453
			// (get) Token: 0x060006F8 RID: 1784 RVA: 0x0001C670 File Offset: 0x0001A870
			public unsafe Object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncWebUtil._DoInvoke_d__4.NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060006F9 RID: 1785 RVA: 0x0001C6B0 File Offset: 0x0001A8B0
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 154881, XrefRangeEnd = 154886, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void System_Collections_IEnumerator_Reset()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncWebUtil._DoInvoke_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x170001C6 RID: 454
			// (get) Token: 0x060006FA RID: 1786 RVA: 0x0001C6E4 File Offset: 0x0001A8E4
			public unsafe Object System.Collections.IEnumerator.Current
			{
				[CallerCount(7)]
				[CachedScanResults(RefRangeStart = 5312, RefRangeEnd = 5319, XrefRangeStart = 5312, XrefRangeEnd = 5319, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
				get
				{
					IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IntPtr* ptr = null;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncWebUtil._DoInvoke_d__4.NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}

			// Token: 0x060006FB RID: 1787 RVA: 0x0000583E File Offset: 0x00003A3E
			public _DoInvoke_d__4(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170001C1 RID: 449
			// (get) Token: 0x060006FC RID: 1788 RVA: 0x0001C724 File Offset: 0x0001A924
			// (set) Token: 0x060006FD RID: 1789 RVA: 0x00005847 File Offset: 0x00003A47
			public unsafe int __1__state
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncWebUtil._DoInvoke_d__4.NativeFieldInfoPtr___1__state);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncWebUtil._DoInvoke_d__4.NativeFieldInfoPtr___1__state)) = value;
				}
			}

			// Token: 0x170001C2 RID: 450
			// (get) Token: 0x060006FE RID: 1790 RVA: 0x0001C74C File Offset: 0x0001A94C
			// (set) Token: 0x060006FF RID: 1791 RVA: 0x00005862 File Offset: 0x00003A62
			public unsafe Object __2__current
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncWebUtil._DoInvoke_d__4.NativeFieldInfoPtr___2__current);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncWebUtil._DoInvoke_d__4.NativeFieldInfoPtr___2__current), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170001C3 RID: 451
			// (get) Token: 0x06000700 RID: 1792 RVA: 0x0001C77C File Offset: 0x0001A97C
			// (set) Token: 0x06000701 RID: 1793 RVA: 0x00005881 File Offset: 0x00003A81
			public unsafe int delayInSeconds
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncWebUtil._DoInvoke_d__4.NativeFieldInfoPtr_delayInSeconds);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncWebUtil._DoInvoke_d__4.NativeFieldInfoPtr_delayInSeconds)) = value;
				}
			}

			// Token: 0x170001C4 RID: 452
			// (get) Token: 0x06000702 RID: 1794 RVA: 0x0001C7A4 File Offset: 0x0001A9A4
			// (set) Token: 0x06000703 RID: 1795 RVA: 0x0000589C File Offset: 0x00003A9C
			public unsafe Action a
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncWebUtil._DoInvoke_d__4.NativeFieldInfoPtr_a);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncWebUtil._DoInvoke_d__4.NativeFieldInfoPtr_a), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000482 RID: 1154
			private static readonly IntPtr NativeFieldInfoPtr___1__state;

			// Token: 0x04000483 RID: 1155
			private static readonly IntPtr NativeFieldInfoPtr___2__current;

			// Token: 0x04000484 RID: 1156
			private static readonly IntPtr NativeFieldInfoPtr_delayInSeconds;

			// Token: 0x04000485 RID: 1157
			private static readonly IntPtr NativeFieldInfoPtr_a;

			// Token: 0x04000486 RID: 1158
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Int32_0;

			// Token: 0x04000487 RID: 1159
			private static readonly IntPtr NativeMethodInfoPtr_System_IDisposable_Dispose_Private_Virtual_Final_New_Void_0;

			// Token: 0x04000488 RID: 1160
			private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Private_Virtual_Final_New_Boolean_0;

			// Token: 0x04000489 RID: 1161
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_Generic_IEnumerator_System_Object__get_Current_Private_Virtual_Final_New_get_Object_0;

			// Token: 0x0400048A RID: 1162
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_Reset_Private_Virtual_Final_New_Void_0;

			// Token: 0x0400048B RID: 1163
			private static readonly IntPtr NativeMethodInfoPtr_System_Collections_IEnumerator_get_Current_Private_Virtual_Final_New_get_Object_0;
		}
	}
}
