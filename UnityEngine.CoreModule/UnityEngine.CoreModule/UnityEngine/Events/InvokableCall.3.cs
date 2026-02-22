using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.Events
{
	// Token: 0x020000FE RID: 254
	public class InvokableCall<T1, T2> : BaseInvokableCall
	{
		// Token: 0x06001576 RID: 5494 RVA: 0x000518C0 File Offset: 0x0004FAC0
		// Note: this type is marked as 'beforefieldinit'.
		static InvokableCall()
		{
			Il2CppClassPointerStore<InvokableCall<T1, T2>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Events", "InvokableCall`2"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[]
			{
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)),
				Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T2>.NativeClassPtr))
			})).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InvokableCall<T1, T2>>.NativeClassPtr);
			InvokableCall<T1, T2>.NativeFieldInfoPtr_Delegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvokableCall<T1, T2>>.NativeClassPtr, "Delegate");
			InvokableCall<T1, T2>.NativeMethodInfoPtr_add_Delegate_Protected_add_Void_UnityAction_2_T1_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokableCall<T1, T2>>.NativeClassPtr, 100664877);
			InvokableCall<T1, T2>.NativeMethodInfoPtr_remove_Delegate_Protected_rem_Void_UnityAction_2_T1_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokableCall<T1, T2>>.NativeClassPtr, 100664878);
			InvokableCall<T1, T2>.NativeMethodInfoPtr__ctor_Public_Void_Object_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokableCall<T1, T2>>.NativeClassPtr, 100664879);
			InvokableCall<T1, T2>.NativeMethodInfoPtr__ctor_Public_Void_UnityAction_2_T1_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokableCall<T1, T2>>.NativeClassPtr, 100664880);
			InvokableCall<T1, T2>.NativeMethodInfoPtr_Invoke_Public_Virtual_Void_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokableCall<T1, T2>>.NativeClassPtr, 100664881);
			InvokableCall<T1, T2>.NativeMethodInfoPtr_Invoke_Public_Void_T1_T2_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokableCall<T1, T2>>.NativeClassPtr, 100664882);
			InvokableCall<T1, T2>.NativeMethodInfoPtr_Find_Public_Virtual_Boolean_Object_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokableCall<T1, T2>>.NativeClassPtr, 100664883);
		}

		// Token: 0x06001577 RID: 5495 RVA: 0x000519E0 File Offset: 0x0004FBE0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_Delegate(UnityAction<T1, T2> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvokableCall<T1, T2>.NativeMethodInfoPtr_add_Delegate_Protected_add_Void_UnityAction_2_T1_T2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001578 RID: 5496 RVA: 0x00051A24 File Offset: 0x0004FC24
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_Delegate(UnityAction<T1, T2> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvokableCall<T1, T2>.NativeMethodInfoPtr_remove_Delegate_Protected_rem_Void_UnityAction_2_T1_T2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001579 RID: 5497 RVA: 0x00051A68 File Offset: 0x0004FC68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80148, XrefRangeEnd = 80157, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InvokableCall(Object target, MethodInfo theFunction)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InvokableCall<T1, T2>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(theFunction);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvokableCall<T1, T2>.NativeMethodInfoPtr__ctor_Public_Void_Object_MethodInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600157A RID: 5498 RVA: 0x00051AC8 File Offset: 0x0004FCC8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InvokableCall(UnityAction<T1, T2> action)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InvokableCall<T1, T2>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvokableCall<T1, T2>.NativeMethodInfoPtr__ctor_Public_Void_UnityAction_2_T1_T2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600157B RID: 5499 RVA: 0x00051B14 File Offset: 0x0004FD14
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80157, XrefRangeEnd = 80162, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Invoke(Il2CppReferenceArray<Object> args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InvokableCall<T1, T2>.NativeMethodInfoPtr_Invoke_Public_Virtual_Void_Il2CppReferenceArray_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600157C RID: 5500 RVA: 0x00051B64 File Offset: 0x0004FD64
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80162, XrefRangeEnd = 80163, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Invoke(T1 args0, T2 args1)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T1).IsValueType)
				{
					T1 t = args0;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref args0;
				}
				ptr2 = intPtr;
			}
			ref IntPtr ptr3 = ref ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr2;
			if (!typeof(T2).IsValueType)
			{
				T2 t2 = args1;
				intPtr2 = ((t2 is string) ? IL2CPP.ManagedStringToIl2Cpp(t2 as string) : IL2CPP.Il2CppObjectBaseToPtr(t2 as Il2CppObjectBase));
			}
			else
			{
				intPtr2 = ref args1;
			}
			ptr3 = intPtr2;
			IntPtr intPtr4;
			IntPtr intPtr3 = IL2CPP.il2cpp_runtime_invoke(InvokableCall<T1, T2>.NativeMethodInfoPtr_Invoke_Public_Void_T1_T2_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr4);
			Il2CppException.RaiseExceptionIfNecessary(intPtr4);
		}

		// Token: 0x0600157D RID: 5501 RVA: 0x00051C24 File Offset: 0x0004FE24
		[CallerCount(0)]
		public unsafe override bool Find(Object targetObj, MethodInfo method)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(targetObj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(method);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InvokableCall<T1, T2>.NativeMethodInfoPtr_Find_Public_Virtual_Boolean_Object_MethodInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x0600157E RID: 5502 RVA: 0x0000C47D File Offset: 0x0000A67D
		public InvokableCall(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x0600157F RID: 5503 RVA: 0x00051C90 File Offset: 0x0004FE90
		// (set) Token: 0x06001580 RID: 5504 RVA: 0x0000C486 File Offset: 0x0000A686
		public unsafe UnityAction<T1, T2> Delegate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvokableCall<T1, T2>.NativeFieldInfoPtr_Delegate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<T1, T2>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvokableCall<T1, T2>.NativeFieldInfoPtr_Delegate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000FF3 RID: 4083
		private static readonly IntPtr NativeFieldInfoPtr_Delegate;

		// Token: 0x04000FF4 RID: 4084
		private static readonly IntPtr NativeMethodInfoPtr_add_Delegate_Protected_add_Void_UnityAction_2_T1_T2_0;

		// Token: 0x04000FF5 RID: 4085
		private static readonly IntPtr NativeMethodInfoPtr_remove_Delegate_Protected_rem_Void_UnityAction_2_T1_T2_0;

		// Token: 0x04000FF6 RID: 4086
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_MethodInfo_0;

		// Token: 0x04000FF7 RID: 4087
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UnityAction_2_T1_T2_0;

		// Token: 0x04000FF8 RID: 4088
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_Void_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000FF9 RID: 4089
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Void_T1_T2_0;

		// Token: 0x04000FFA RID: 4090
		private static readonly IntPtr NativeMethodInfoPtr_Find_Public_Virtual_Boolean_Object_MethodInfo_0;
	}
}
