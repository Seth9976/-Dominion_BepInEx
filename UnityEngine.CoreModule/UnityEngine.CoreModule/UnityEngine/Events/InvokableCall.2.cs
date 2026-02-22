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
	// Token: 0x020000FD RID: 253
	public class InvokableCall<T1> : BaseInvokableCall
	{
		// Token: 0x0600156B RID: 5483 RVA: 0x00051510 File Offset: 0x0004F710
		// Note: this type is marked as 'beforefieldinit'.
		static InvokableCall()
		{
			Il2CppClassPointerStore<InvokableCall<T1>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Events", "InvokableCall`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T1>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<InvokableCall<T1>>.NativeClassPtr);
			InvokableCall<T1>.NativeFieldInfoPtr_Delegate = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<InvokableCall<T1>>.NativeClassPtr, "Delegate");
			InvokableCall<T1>.NativeMethodInfoPtr_add_Delegate_Protected_add_Void_UnityAction_1_T1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokableCall<T1>>.NativeClassPtr, 100664870);
			InvokableCall<T1>.NativeMethodInfoPtr_remove_Delegate_Protected_rem_Void_UnityAction_1_T1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokableCall<T1>>.NativeClassPtr, 100664871);
			InvokableCall<T1>.NativeMethodInfoPtr__ctor_Public_Void_Object_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokableCall<T1>>.NativeClassPtr, 100664872);
			InvokableCall<T1>.NativeMethodInfoPtr__ctor_Public_Void_UnityAction_1_T1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokableCall<T1>>.NativeClassPtr, 100664873);
			InvokableCall<T1>.NativeMethodInfoPtr_Invoke_Public_Virtual_Void_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokableCall<T1>>.NativeClassPtr, 100664874);
			InvokableCall<T1>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T1_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokableCall<T1>>.NativeClassPtr, 100664875);
			InvokableCall<T1>.NativeMethodInfoPtr_Find_Public_Virtual_Boolean_Object_MethodInfo_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<InvokableCall<T1>>.NativeClassPtr, 100664876);
		}

		// Token: 0x0600156C RID: 5484 RVA: 0x0005161C File Offset: 0x0004F81C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80055, XrefRangeEnd = 80060, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void add_Delegate(UnityAction<T1> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvokableCall<T1>.NativeMethodInfoPtr_add_Delegate_Protected_add_Void_UnityAction_1_T1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600156D RID: 5485 RVA: 0x00051660 File Offset: 0x0004F860
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80060, XrefRangeEnd = 80065, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void remove_Delegate(UnityAction<T1> value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvokableCall<T1>.NativeMethodInfoPtr_remove_Delegate_Protected_rem_Void_UnityAction_1_T1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x0600156E RID: 5486 RVA: 0x000516A4 File Offset: 0x0004F8A4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80065, XrefRangeEnd = 80087, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InvokableCall(Object target, MethodInfo theFunction)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InvokableCall<T1>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(theFunction);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvokableCall<T1>.NativeMethodInfoPtr__ctor_Public_Void_Object_MethodInfo_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600156F RID: 5487 RVA: 0x00051704 File Offset: 0x0004F904
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80087, XrefRangeEnd = 80144, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe InvokableCall(UnityAction<T1> action)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<InvokableCall<T1>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(action);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(InvokableCall<T1>.NativeMethodInfoPtr__ctor_Public_Void_UnityAction_1_T1_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001570 RID: 5488 RVA: 0x00051750 File Offset: 0x0004F950
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80144, XrefRangeEnd = 80147, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Invoke(Il2CppReferenceArray<Object> args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InvokableCall<T1>.NativeMethodInfoPtr_Invoke_Public_Virtual_Void_Il2CppReferenceArray_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001571 RID: 5489 RVA: 0x000517A0 File Offset: 0x0004F9A0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80147, XrefRangeEnd = 80148, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Invoke(T1 args0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
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
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InvokableCall<T1>.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T1_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x06001572 RID: 5490 RVA: 0x00051824 File Offset: 0x0004FA24
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
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), InvokableCall<T1>.NativeMethodInfoPtr_Find_Public_Virtual_Boolean_Object_MethodInfo_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001573 RID: 5491 RVA: 0x0000C455 File Offset: 0x0000A655
		public InvokableCall(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06001574 RID: 5492 RVA: 0x00051890 File Offset: 0x0004FA90
		// (set) Token: 0x06001575 RID: 5493 RVA: 0x0000C45E File Offset: 0x0000A65E
		public unsafe UnityAction<T1> Delegate
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvokableCall<T1>.NativeFieldInfoPtr_Delegate);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<UnityAction<T1>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(InvokableCall<T1>.NativeFieldInfoPtr_Delegate), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04000FEB RID: 4075
		private static readonly IntPtr NativeFieldInfoPtr_Delegate;

		// Token: 0x04000FEC RID: 4076
		private static readonly IntPtr NativeMethodInfoPtr_add_Delegate_Protected_add_Void_UnityAction_1_T1_0;

		// Token: 0x04000FED RID: 4077
		private static readonly IntPtr NativeMethodInfoPtr_remove_Delegate_Protected_rem_Void_UnityAction_1_T1_0;

		// Token: 0x04000FEE RID: 4078
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_MethodInfo_0;

		// Token: 0x04000FEF RID: 4079
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_UnityAction_1_T1_0;

		// Token: 0x04000FF0 RID: 4080
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_Void_Il2CppReferenceArray_1_Object_0;

		// Token: 0x04000FF1 RID: 4081
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_T1_0;

		// Token: 0x04000FF2 RID: 4082
		private static readonly IntPtr NativeMethodInfoPtr_Find_Public_Virtual_Boolean_Object_MethodInfo_0;
	}
}
