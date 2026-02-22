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
	// Token: 0x0200002F RID: 47
	public class SA_Event<T, T1> : Object
	{
		// Token: 0x06000180 RID: 384 RVA: 0x0000991C File Offset: 0x00007B1C
		// Note: this type is marked as 'beforefieldinit'.
		static SA_Event()
		{
			Il2CppClassPointerStore<SA_Event<T, T1>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("SA.Foundation.dll", "SA.Foundation.Events", "SA_Event`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_Event<T, T1>>.NativeClassPtr);
			SA_Event<T, T1>.NativeFieldInfoPtr_m_targetedActions = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_Event<T, T1>>.NativeClassPtr, "m_targetedActions");
			SA_Event<T, T1>.NativeMethodInfoPtr_AddListener_Public_Virtual_Final_New_Void_Action_2_T_T1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Event<T, T1>>.NativeClassPtr, 100663534);
			SA_Event<T, T1>.NativeMethodInfoPtr_AddSafeListener_Public_Virtual_Final_New_Void_Object_Action_2_T_T1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Event<T, T1>>.NativeClassPtr, 100663535);
			SA_Event<T, T1>.NativeMethodInfoPtr_Invoke_Public_Void_T_T1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Event<T, T1>>.NativeClassPtr, 100663536);
			SA_Event<T, T1>.NativeMethodInfoPtr_RemoveListener_Public_Virtual_Final_New_Void_Action_2_T_T1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Event<T, T1>>.NativeClassPtr, 100663537);
			SA_Event<T, T1>.NativeMethodInfoPtr_RemoveAllListeners_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Event<T, T1>>.NativeClassPtr, 100663538);
			SA_Event<T, T1>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Event<T, T1>>.NativeClassPtr, 100663539);
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00009A28 File Offset: 0x00007C28
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AddListener(Action<T, T1> listner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(listner);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Event<T, T1>.NativeMethodInfoPtr_AddListener_Public_Virtual_Final_New_Void_Action_2_T_T1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000182 RID: 386 RVA: 0x00009A6C File Offset: 0x00007C6C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void AddSafeListener(Object callbackTarget, Action<T, T1> listner)
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Event<T, T1>.NativeMethodInfoPtr_AddSafeListener_Public_Virtual_Final_New_Void_Object_Action_2_T_T1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000183 RID: 387 RVA: 0x00009AC0 File Offset: 0x00007CC0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100447, XrefRangeEnd = 100468, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(T obj, T1 obj1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
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
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T1).IsValueType)
			{
				T1 t2 = obj1;
				intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref obj1;
			}
			ptr3 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(SA_Event<T, T1>.NativeMethodInfoPtr_Invoke_Public_Void_T_T1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
		}

		// Token: 0x06000184 RID: 388 RVA: 0x00009B80 File Offset: 0x00007D80
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 100468, XrefRangeEnd = 100477, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void RemoveListener(Action<T, T1> listner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(listner);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Event<T, T1>.NativeMethodInfoPtr_RemoveListener_Public_Virtual_Final_New_Void_Action_2_T_T1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000185 RID: 389 RVA: 0x00009BC4 File Offset: 0x00007DC4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void RemoveAllListeners()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Event<T, T1>.NativeMethodInfoPtr_RemoveAllListeners_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000186 RID: 390 RVA: 0x00009BF8 File Offset: 0x00007DF8
		[CallerCount(4)]
		[CachedScanResults(RefRangeStart = 100443, RefRangeEnd = 100447, XrefRangeStart = 100443, XrefRangeEnd = 100447, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe SA_Event()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_Event<T, T1>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Event<T, T1>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000187 RID: 391 RVA: 0x0000257F File Offset: 0x0000077F
		public SA_Event(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000188 RID: 392 RVA: 0x00009C34 File Offset: 0x00007E34
		// (set) Token: 0x06000189 RID: 393 RVA: 0x00002588 File Offset: 0x00000788
		public unsafe List<SA_Event<T, T1>.SafeActionInfo> m_targetedActions
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_Event<T, T1>.NativeFieldInfoPtr_m_targetedActions);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<List<SA_Event<T, T1>.SafeActionInfo>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_Event<T, T1>.NativeFieldInfoPtr_m_targetedActions), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000110 RID: 272
		private static readonly IntPtr NativeFieldInfoPtr_m_targetedActions;

		// Token: 0x04000111 RID: 273
		private static readonly IntPtr NativeMethodInfoPtr_AddListener_Public_Virtual_Final_New_Void_Action_2_T_T1_0;

		// Token: 0x04000112 RID: 274
		private static readonly IntPtr NativeMethodInfoPtr_AddSafeListener_Public_Virtual_Final_New_Void_Object_Action_2_T_T1_0;

		// Token: 0x04000113 RID: 275
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Void_T_T1_0;

		// Token: 0x04000114 RID: 276
		private static readonly IntPtr NativeMethodInfoPtr_RemoveListener_Public_Virtual_Final_New_Void_Action_2_T_T1_0;

		// Token: 0x04000115 RID: 277
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAllListeners_Public_Void_0;

		// Token: 0x04000116 RID: 278
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x0200004F RID: 79
		public class SafeActionInfo : Object
		{
			// Token: 0x060003EC RID: 1004 RVA: 0x00013580 File Offset: 0x00011780
			// Note: this type is marked as 'beforefieldinit'.
			static SafeActionInfo()
			{
				Il2CppClassPointerStore<SA_Event<T, T1>.SafeActionInfo>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<SA_Event<T, T1>>.NativeClassPtr, "SafeActionInfo"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
				{
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)),
					Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr))
				})).TypeHandle.value);
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SA_Event<T, T1>.SafeActionInfo>.NativeClassPtr);
				SA_Event<T, T1>.SafeActionInfo.NativeFieldInfoPtr_Action = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_Event<T, T1>.SafeActionInfo>.NativeClassPtr, "Action");
				SA_Event<T, T1>.SafeActionInfo.NativeFieldInfoPtr_Target = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SA_Event<T, T1>.SafeActionInfo>.NativeClassPtr, "Target");
				SA_Event<T, T1>.SafeActionInfo.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SA_Event<T, T1>.SafeActionInfo>.NativeClassPtr, 100663892);
			}

			// Token: 0x060003ED RID: 1005 RVA: 0x00013634 File Offset: 0x00011834
			[CallerCount(17)]
			[CachedScanResults(RefRangeStart = 44661, RefRangeEnd = 44678, XrefRangeStart = 44661, XrefRangeEnd = 44678, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe SafeActionInfo()
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<SA_Event<T, T1>.SafeActionInfo>.NativeClassPtr))
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SA_Event<T, T1>.SafeActionInfo.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060003EE RID: 1006 RVA: 0x000030EB File Offset: 0x000012EB
			public SafeActionInfo(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x170000C2 RID: 194
			// (get) Token: 0x060003EF RID: 1007 RVA: 0x00013670 File Offset: 0x00011870
			// (set) Token: 0x060003F0 RID: 1008 RVA: 0x000030F4 File Offset: 0x000012F4
			public unsafe Action<T, T1> Action
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_Event<T, T1>.SafeActionInfo.NativeFieldInfoPtr_Action);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<T, T1>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_Event<T, T1>.SafeActionInfo.NativeFieldInfoPtr_Action), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170000C3 RID: 195
			// (get) Token: 0x060003F1 RID: 1009 RVA: 0x000136A0 File Offset: 0x000118A0
			// (set) Token: 0x060003F2 RID: 1010 RVA: 0x00003113 File Offset: 0x00001313
			public unsafe Object Target
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_Event<T, T1>.SafeActionInfo.NativeFieldInfoPtr_Target);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(SA_Event<T, T1>.SafeActionInfo.NativeFieldInfoPtr_Target), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x04000306 RID: 774
			private static readonly IntPtr NativeFieldInfoPtr_Action;

			// Token: 0x04000307 RID: 775
			private static readonly IntPtr NativeFieldInfoPtr_Target;

			// Token: 0x04000308 RID: 776
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
		}
	}
}
