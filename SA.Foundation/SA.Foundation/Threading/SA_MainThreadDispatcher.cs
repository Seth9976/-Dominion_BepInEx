using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using SA.Foundation.Patterns;

namespace SA.Foundation.Threading
{
	// Token: 0x0200001E RID: 30
	public static class SA_MainThreadDispatcher : Object
	{
		// Token: 0x060000DD RID: 221 RVA: 0x000071C4 File Offset: 0x000053C4
		// Note: this type is marked as 'beforefieldinit'.
		static SA_MainThreadDispatcher()
		{
			Il2CppClassPointerStore<SA_MainThreadDispatcher>.NativeClassPtr = IL2CPP.GetIl2CppClass("SA.Foundation.dll", "SA.Foundation.Threading", "SA_MainThreadDispatcher");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_MainThreadDispatcher>.NativeClassPtr);
			SA_MainThreadDispatcher.NativeMethodInfoPtr_Init_Public_Static_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_MainThreadDispatcher>.NativeClassPtr, 100663445);
			SA_MainThreadDispatcher.NativeMethodInfoPtr_Enqueue_Public_Static_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_MainThreadDispatcher>.NativeClassPtr, 100663446);
		}

		// Token: 0x060000DE RID: 222 RVA: 0x0000721C File Offset: 0x0000541C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99543, XrefRangeEnd = 99551, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Init()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_MainThreadDispatcher.NativeMethodInfoPtr_Init_Public_Static_Void_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00007244 File Offset: 0x00005444
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99551, XrefRangeEnd = 99563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void Enqueue(Action action)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_MainThreadDispatcher.NativeMethodInfoPtr_Enqueue_Public_Static_Void_Action_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x000022E7 File Offset: 0x000004E7
		public SA_MainThreadDispatcher(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040000A7 RID: 167
		private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Static_Void_0;

		// Token: 0x040000A8 RID: 168
		private static readonly IntPtr NativeMethodInfoPtr_Enqueue_Public_Static_Void_Action_0;

		// Token: 0x0200004D RID: 77
		public class MainThreadDispatcherPlaymode : SA_Singleton<SA_MainThreadDispatcher.MainThreadDispatcherPlaymode>
		{
			// Token: 0x060003DD RID: 989 RVA: 0x000132A0 File Offset: 0x000114A0
			// Note: this type is marked as 'beforefieldinit'.
			static MainThreadDispatcherPlaymode()
			{
				Il2CppClassPointerStore<SA_MainThreadDispatcher.MainThreadDispatcherPlaymode>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SA_MainThreadDispatcher>.NativeClassPtr, "MainThreadDispatcherPlaymode");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_MainThreadDispatcher.MainThreadDispatcherPlaymode>.NativeClassPtr);
				SA_MainThreadDispatcher.MainThreadDispatcherPlaymode.NativeFieldInfoPtr_s_executionQueue = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_MainThreadDispatcher.MainThreadDispatcherPlaymode>.NativeClassPtr, "s_executionQueue");
				SA_MainThreadDispatcher.MainThreadDispatcherPlaymode.NativeMethodInfoPtr_Init_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_MainThreadDispatcher.MainThreadDispatcherPlaymode>.NativeClassPtr, 100663886);
				SA_MainThreadDispatcher.MainThreadDispatcherPlaymode.NativeMethodInfoPtr_Update_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_MainThreadDispatcher.MainThreadDispatcherPlaymode>.NativeClassPtr, 100663887);
				SA_MainThreadDispatcher.MainThreadDispatcherPlaymode.NativeMethodInfoPtr_Enqueue_Public_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_MainThreadDispatcher.MainThreadDispatcherPlaymode>.NativeClassPtr, 100663888);
				SA_MainThreadDispatcher.MainThreadDispatcherPlaymode.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_MainThreadDispatcher.MainThreadDispatcherPlaymode>.NativeClassPtr, 100663889);
			}

			// Token: 0x060003DE RID: 990 RVA: 0x00013330 File Offset: 0x00011530
			[CallerCount(3728)]
			[CachedScanResults(RefRangeStart = 24, RefRangeEnd = 3752, XrefRangeStart = 24, XrefRangeEnd = 3752, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Init()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_MainThreadDispatcher.MainThreadDispatcherPlaymode.NativeMethodInfoPtr_Init_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003DF RID: 991 RVA: 0x00013364 File Offset: 0x00011564
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99510, XrefRangeEnd = 99528, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Update()
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_MainThreadDispatcher.MainThreadDispatcherPlaymode.NativeMethodInfoPtr_Update_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003E0 RID: 992 RVA: 0x00013398 File Offset: 0x00011598
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 99536, RefRangeEnd = 99537, XrefRangeStart = 99528, XrefRangeEnd = 99536, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Enqueue(Action action)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_MainThreadDispatcher.MainThreadDispatcherPlaymode.NativeMethodInfoPtr_Enqueue_Public_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x060003E1 RID: 993 RVA: 0x000133DC File Offset: 0x000115DC
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 99537, XrefRangeEnd = 99543, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe MainThreadDispatcherPlaymode()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_MainThreadDispatcher.MainThreadDispatcherPlaymode>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_MainThreadDispatcher.MainThreadDispatcherPlaymode.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003E2 RID: 994 RVA: 0x00003089 File Offset: 0x00001289
			public MainThreadDispatcherPlaymode(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000BF RID: 191
			// (get) Token: 0x060003E3 RID: 995 RVA: 0x00013418 File Offset: 0x00011618
			// (set) Token: 0x060003E4 RID: 996 RVA: 0x00003092 File Offset: 0x00001292
			public unsafe static Queue<Action> s_executionQueue
			{
				get
				{
					IntPtr intPtr;
					IL2CPP.il2cpp_field_static_get_value(SA_MainThreadDispatcher.MainThreadDispatcherPlaymode.NativeFieldInfoPtr_s_executionQueue, (void*)(&intPtr));
					IntPtr intPtr2 = intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Queue<Action>>(intPtr2) : null;
				}
				set
				{
					IL2CPP.il2cpp_field_static_set_value(SA_MainThreadDispatcher.MainThreadDispatcherPlaymode.NativeFieldInfoPtr_s_executionQueue, IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x040002FE RID: 766
			private static readonly IntPtr NativeFieldInfoPtr_s_executionQueue;

			// Token: 0x040002FF RID: 767
			private static readonly IntPtr NativeMethodInfoPtr_Init_Public_Void_0;

			// Token: 0x04000300 RID: 768
			private static readonly IntPtr NativeMethodInfoPtr_Update_Public_Void_0;

			// Token: 0x04000301 RID: 769
			private static readonly IntPtr NativeMethodInfoPtr_Enqueue_Public_Void_Action_0;

			// Token: 0x04000302 RID: 770
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
