using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace SA.Foundation.Events
{
	// Token: 0x0200002E RID: 46
	public class SA_Event<T> : Object
	{
		// Token: 0x06000176 RID: 374 RVA: 0x00009630 File Offset: 0x00007830
		// Note: this type is marked as 'beforefieldinit'.
		static SA_Event()
		{
			Il2CppClassPointerStore<SA_Event<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("SA.Foundation.dll", "SA.Foundation.Events", "SA_Event`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_Event<T>>.NativeClassPtr);
			SA_Event<T>.NativeFieldInfoPtr_m_targetedActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_Event<T>>.NativeClassPtr, "m_targetedActions");
			SA_Event<T>.NativeMethodInfoPtr_AddListener_Public_Virtual_Final_New_Void_Action_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Event<T>>.NativeClassPtr, 100663528);
			SA_Event<T>.NativeMethodInfoPtr_AddSafeListener_Public_Virtual_Final_New_Void_Object_Action_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Event<T>>.NativeClassPtr, 100663529);
			SA_Event<T>.NativeMethodInfoPtr_Invoke_Public_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Event<T>>.NativeClassPtr, 100663530);
			SA_Event<T>.NativeMethodInfoPtr_RemoveListener_Public_Virtual_Final_New_Void_Action_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Event<T>>.NativeClassPtr, 100663531);
			SA_Event<T>.NativeMethodInfoPtr_RemoveAllListeners_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Event<T>>.NativeClassPtr, 100663532);
			SA_Event<T>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Event<T>>.NativeClassPtr, 100663533);
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00009728 File Offset: 0x00007928
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100403, XrefRangeEnd = 100405, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AddListener(Action<T> listner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(listner);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Event<T>.NativeMethodInfoPtr_AddListener_Public_Virtual_Final_New_Void_Action_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000178 RID: 376 RVA: 0x0000976C File Offset: 0x0000796C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100405, XrefRangeEnd = 100407, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AddSafeListener(Object callbackTarget, Action<T> listner)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Event<T>.NativeMethodInfoPtr_AddSafeListener_Public_Virtual_Final_New_Void_Object_Action_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000179 RID: 377 RVA: 0x000097C0 File Offset: 0x000079C0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 100428, RefRangeEnd = 100430, XrefRangeStart = 100407, XrefRangeEnd = 100428, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(T obj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = obj;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref obj;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(SA_Event<T>.NativeMethodInfoPtr_Invoke_Public_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00009838 File Offset: 0x00007A38
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100430, XrefRangeEnd = 100439, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RemoveListener(Action<T> listner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(listner);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Event<T>.NativeMethodInfoPtr_RemoveListener_Public_Virtual_Final_New_Void_Action_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600017B RID: 379 RVA: 0x0000987C File Offset: 0x00007A7C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100439, XrefRangeEnd = 100440, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveAllListeners()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Event<T>.NativeMethodInfoPtr_RemoveAllListeners_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600017C RID: 380 RVA: 0x000098B0 File Offset: 0x00007AB0
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 100443, RefRangeEnd = 100447, XrefRangeStart = 100440, XrefRangeEnd = 100443, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SA_Event()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_Event<T>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Event<T>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00002557 File Offset: 0x00000757
		public SA_Event(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600017E RID: 382 RVA: 0x000098EC File Offset: 0x00007AEC
		// (set) Token: 0x0600017F RID: 383 RVA: 0x00002560 File Offset: 0x00000760
		public unsafe List<SA_Event<T>.SafeActionInfo> m_targetedActions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_Event<T>.NativeFieldInfoPtr_m_targetedActions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SA_Event<T>.SafeActionInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_Event<T>.NativeFieldInfoPtr_m_targetedActions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000109 RID: 265
		private static readonly IntPtr NativeFieldInfoPtr_m_targetedActions;

		// Token: 0x0400010A RID: 266
		private static readonly IntPtr NativeMethodInfoPtr_AddListener_Public_Virtual_Final_New_Void_Action_1_T_0;

		// Token: 0x0400010B RID: 267
		private static readonly IntPtr NativeMethodInfoPtr_AddSafeListener_Public_Virtual_Final_New_Void_Object_Action_1_T_0;

		// Token: 0x0400010C RID: 268
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Void_T_0;

		// Token: 0x0400010D RID: 269
		private static readonly IntPtr NativeMethodInfoPtr_RemoveListener_Public_Virtual_Final_New_Void_Action_1_T_0;

		// Token: 0x0400010E RID: 270
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAllListeners_Public_Void_0;

		// Token: 0x0400010F RID: 271
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200004E RID: 78
		public class SafeActionInfo : Object
		{
			// Token: 0x060003E5 RID: 997 RVA: 0x00013440 File Offset: 0x00011640
			// Note: this type is marked as 'beforefieldinit'.
			static SafeActionInfo()
			{
				Il2CppClassPointerStore<SA_Event<T>.SafeActionInfo>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SA_Event<T>>.NativeClassPtr, "SafeActionInfo"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_Event<T>.SafeActionInfo>.NativeClassPtr);
				SA_Event<T>.SafeActionInfo.NativeFieldInfoPtr_Action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_Event<T>.SafeActionInfo>.NativeClassPtr, "Action");
				SA_Event<T>.SafeActionInfo.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_Event<T>.SafeActionInfo>.NativeClassPtr, "Target");
				SA_Event<T>.SafeActionInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Event<T>.SafeActionInfo>.NativeClassPtr, 100663891);
			}

			// Token: 0x060003E6 RID: 998 RVA: 0x000134E4 File Offset: 0x000116E4
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 44661, RefRangeEnd = 44678, XrefRangeStart = 44661, XrefRangeEnd = 44678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SafeActionInfo()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_Event<T>.SafeActionInfo>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Event<T>.SafeActionInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003E7 RID: 999 RVA: 0x000030A4 File Offset: 0x000012A4
			public SafeActionInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000C0 RID: 192
			// (get) Token: 0x060003E8 RID: 1000 RVA: 0x00013520 File Offset: 0x00011720
			// (set) Token: 0x060003E9 RID: 1001 RVA: 0x000030AD File Offset: 0x000012AD
			public unsafe Action<T> Action
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_Event<T>.SafeActionInfo.NativeFieldInfoPtr_Action);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<T>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_Event<T>.SafeActionInfo.NativeFieldInfoPtr_Action), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000C1 RID: 193
			// (get) Token: 0x060003EA RID: 1002 RVA: 0x00013550 File Offset: 0x00011750
			// (set) Token: 0x060003EB RID: 1003 RVA: 0x000030CC File Offset: 0x000012CC
			public unsafe Object Target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_Event<T>.SafeActionInfo.NativeFieldInfoPtr_Target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_Event<T>.SafeActionInfo.NativeFieldInfoPtr_Target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000303 RID: 771
			private static readonly IntPtr NativeFieldInfoPtr_Action;

			// Token: 0x04000304 RID: 772
			private static readonly IntPtr NativeFieldInfoPtr_Target;

			// Token: 0x04000305 RID: 773
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
