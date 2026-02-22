using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace SA.Foundation.Events
{
	// Token: 0x02000030 RID: 48
	public class SA_Event : Object
	{
		// Token: 0x0600018A RID: 394 RVA: 0x00009C64 File Offset: 0x00007E64
		// Note: this type is marked as 'beforefieldinit'.
		static SA_Event()
		{
			Il2CppClassPointerStore<SA_Event>.NativeClassPtr = IL2CPP.GetIl2CppClass("SA.Foundation.dll", "SA.Foundation.Events", "SA_Event");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_Event>.NativeClassPtr);
			SA_Event.NativeFieldInfoPtr_m_targetedActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_Event>.NativeClassPtr, "m_targetedActions");
			SA_Event.NativeMethodInfoPtr_AddListener_Public_Virtual_Final_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Event>.NativeClassPtr, 100663540);
			SA_Event.NativeMethodInfoPtr_AddSafeListener_Public_Virtual_Final_New_Void_Object_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Event>.NativeClassPtr, 100663541);
			SA_Event.NativeMethodInfoPtr_Invoke_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Event>.NativeClassPtr, 100663542);
			SA_Event.NativeMethodInfoPtr_RemoveListener_Public_Virtual_Final_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Event>.NativeClassPtr, 100663543);
			SA_Event.NativeMethodInfoPtr_RemoveAllListeners_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Event>.NativeClassPtr, 100663544);
			SA_Event.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Event>.NativeClassPtr, 100663545);
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00009D20 File Offset: 0x00007F20
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100477, XrefRangeEnd = 100484, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AddListener(Action listner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(listner);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Event.NativeMethodInfoPtr_AddListener_Public_Virtual_Final_New_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600018C RID: 396 RVA: 0x00009D64 File Offset: 0x00007F64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100484, XrefRangeEnd = 100491, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AddSafeListener(Object callbackTarget, Action listner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(callbackTarget);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(listner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Event.NativeMethodInfoPtr_AddSafeListener_Public_Virtual_Final_New_Void_Object_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600018D RID: 397 RVA: 0x00009DB8 File Offset: 0x00007FB8
		[CallerCount(3)]
		[CachedScanResults(RefRangeStart = 100530, RefRangeEnd = 100533, XrefRangeStart = 100491, XrefRangeEnd = 100530, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Event.NativeMethodInfoPtr_Invoke_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600018E RID: 398 RVA: 0x00009DEC File Offset: 0x00007FEC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100533, XrefRangeEnd = 100552, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RemoveListener(Action listner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(listner);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Event.NativeMethodInfoPtr_RemoveListener_Public_Virtual_Final_New_Void_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00009E30 File Offset: 0x00008030
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100552, XrefRangeEnd = 100556, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveAllListeners()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Event.NativeMethodInfoPtr_RemoveAllListeners_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00009E64 File Offset: 0x00008064
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 100563, RefRangeEnd = 100565, XrefRangeStart = 100556, XrefRangeEnd = 100563, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SA_Event()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_Event>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Event.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000191 RID: 401 RVA: 0x000025A7 File Offset: 0x000007A7
		public SA_Event(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000192 RID: 402 RVA: 0x00009EA0 File Offset: 0x000080A0
		// (set) Token: 0x06000193 RID: 403 RVA: 0x000025B0 File Offset: 0x000007B0
		public unsafe List<SA_Event.SafeActionInfo> m_targetedActions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_Event.NativeFieldInfoPtr_m_targetedActions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SA_Event.SafeActionInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_Event.NativeFieldInfoPtr_m_targetedActions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000117 RID: 279
		private static readonly IntPtr NativeFieldInfoPtr_m_targetedActions;

		// Token: 0x04000118 RID: 280
		private static readonly IntPtr NativeMethodInfoPtr_AddListener_Public_Virtual_Final_New_Void_Action_0;

		// Token: 0x04000119 RID: 281
		private static readonly IntPtr NativeMethodInfoPtr_AddSafeListener_Public_Virtual_Final_New_Void_Object_Action_0;

		// Token: 0x0400011A RID: 282
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Void_0;

		// Token: 0x0400011B RID: 283
		private static readonly IntPtr NativeMethodInfoPtr_RemoveListener_Public_Virtual_Final_New_Void_Action_0;

		// Token: 0x0400011C RID: 284
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAllListeners_Public_Void_0;

		// Token: 0x0400011D RID: 285
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000050 RID: 80
		public class SafeActionInfo : Object
		{
			// Token: 0x060003F3 RID: 1011 RVA: 0x000136D0 File Offset: 0x000118D0
			// Note: this type is marked as 'beforefieldinit'.
			static SafeActionInfo()
			{
				Il2CppClassPointerStore<SA_Event.SafeActionInfo>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SA_Event>.NativeClassPtr, "SafeActionInfo");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_Event.SafeActionInfo>.NativeClassPtr);
				SA_Event.SafeActionInfo.NativeFieldInfoPtr_Action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_Event.SafeActionInfo>.NativeClassPtr, "Action");
				SA_Event.SafeActionInfo.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_Event.SafeActionInfo>.NativeClassPtr, "Target");
				SA_Event.SafeActionInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Event.SafeActionInfo>.NativeClassPtr, 100663893);
			}

			// Token: 0x060003F4 RID: 1012 RVA: 0x00013738 File Offset: 0x00011938
			[CallerCount(817)]
			[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SafeActionInfo()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_Event.SafeActionInfo>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Event.SafeActionInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003F5 RID: 1013 RVA: 0x00003132 File Offset: 0x00001332
			public SafeActionInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000C4 RID: 196
			// (get) Token: 0x060003F6 RID: 1014 RVA: 0x00013774 File Offset: 0x00011974
			// (set) Token: 0x060003F7 RID: 1015 RVA: 0x0000313B File Offset: 0x0000133B
			public unsafe Action Action
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_Event.SafeActionInfo.NativeFieldInfoPtr_Action);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_Event.SafeActionInfo.NativeFieldInfoPtr_Action), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000C5 RID: 197
			// (get) Token: 0x060003F8 RID: 1016 RVA: 0x000137A4 File Offset: 0x000119A4
			// (set) Token: 0x060003F9 RID: 1017 RVA: 0x0000315A File Offset: 0x0000135A
			public unsafe Object Target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_Event.SafeActionInfo.NativeFieldInfoPtr_Target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_Event.SafeActionInfo.NativeFieldInfoPtr_Target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000309 RID: 777
			private static readonly IntPtr NativeFieldInfoPtr_Action;

			// Token: 0x0400030A RID: 778
			private static readonly IntPtr NativeFieldInfoPtr_Target;

			// Token: 0x0400030B RID: 779
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
