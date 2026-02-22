using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Threading
{
	// Token: 0x02000266 RID: 614
	public sealed class AsyncLocal<T> : Object
	{
		// Token: 0x06002A86 RID: 10886 RVA: 0x000DB66C File Offset: 0x000D986C
		// Note: this type is marked as 'beforefieldinit'.
		static AsyncLocal()
		{
			Il2CppClassPointerStore<AsyncLocal<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Threading", "AsyncLocal`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<AsyncLocal<T>>.NativeClassPtr);
			AsyncLocal<T>.NativeFieldInfoPtr_m_valueChangedHandler = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<AsyncLocal<T>>.NativeClassPtr, "m_valueChangedHandler");
			AsyncLocal<T>.NativeMethodInfoPtr__ctor_Public_Void_Action_1_AsyncLocalValueChangedArgs_1_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncLocal<T>>.NativeClassPtr, 100670059);
			AsyncLocal<T>.NativeMethodInfoPtr_get_Value_Public_get_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncLocal<T>>.NativeClassPtr, 100670060);
			AsyncLocal<T>.NativeMethodInfoPtr_set_Value_Public_set_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncLocal<T>>.NativeClassPtr, 100670061);
			AsyncLocal<T>.NativeMethodInfoPtr_System_Threading_IAsyncLocal_OnValueChanged_Private_Virtual_Final_New_Void_Object_Object_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<AsyncLocal<T>>.NativeClassPtr, 100670062);
		}

		// Token: 0x06002A87 RID: 10887 RVA: 0x000DB73C File Offset: 0x000D993C
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 258322, RefRangeEnd = 258324, XrefRangeStart = 258322, XrefRangeEnd = 258324, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe AsyncLocal(Action<AsyncLocalValueChangedArgs<T>> valueChangedHandler)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<AsyncLocal<T>>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(valueChangedHandler);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncLocal<T>.NativeMethodInfoPtr__ctor_Public_Void_Action_1_AsyncLocalValueChangedArgs_1_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000A1A RID: 2586
		// (get) Token: 0x06002A88 RID: 10888 RVA: 0x000DB788 File Offset: 0x000D9988
		// (set) Token: 0x06002A89 RID: 10889 RVA: 0x000DB7C4 File Offset: 0x000D99C4
		public unsafe T Value
		{
			[CallerCount(4)]
			[CachedScanResults(RefRangeStart = 331226, RefRangeEnd = 331230, XrefRangeStart = 331222, XrefRangeEnd = 331226, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncLocal<T>.NativeMethodInfoPtr_get_Value_Public_get_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, false, true);
			}
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331230, XrefRangeEnd = 331234, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					ref IntPtr ptr2 = ref *ptr;
					IntPtr intPtr;
					if (!typeof(T).IsValueType)
					{
						T t = value;
						intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
					}
					else
					{
						intPtr = ref value;
					}
					ptr2 = intPtr;
					IntPtr intPtr3;
					IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(AsyncLocal<T>.NativeMethodInfoPtr_set_Value_Public_set_Void_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
					Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				}
			}
		}

		// Token: 0x06002A8A RID: 10890 RVA: 0x000DB83C File Offset: 0x000D9A3C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 331234, XrefRangeEnd = 331242, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void System_Threading_IAsyncLocal_OnValueChanged(Object previousValueObj, Object currentValueObj, bool contextChanged)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(previousValueObj);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(currentValueObj);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref contextChanged;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(AsyncLocal<T>.NativeMethodInfoPtr_System_Threading_IAsyncLocal_OnValueChanged_Private_Virtual_Final_New_Void_Object_Object_Boolean_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06002A8B RID: 10891 RVA: 0x0000ED38 File Offset: 0x0000CF38
		public AsyncLocal(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000A19 RID: 2585
		// (get) Token: 0x06002A8C RID: 10892 RVA: 0x000DB8A0 File Offset: 0x000D9AA0
		// (set) Token: 0x06002A8D RID: 10893 RVA: 0x0000ED41 File Offset: 0x0000CF41
		public unsafe Action<AsyncLocalValueChangedArgs<T>> m_valueChangedHandler
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncLocal<T>.NativeFieldInfoPtr_m_valueChangedHandler);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<AsyncLocalValueChangedArgs<T>>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(AsyncLocal<T>.NativeFieldInfoPtr_m_valueChangedHandler), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04002543 RID: 9539
		private static readonly IntPtr NativeFieldInfoPtr_m_valueChangedHandler;

		// Token: 0x04002544 RID: 9540
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Action_1_AsyncLocalValueChangedArgs_1_T_0;

		// Token: 0x04002545 RID: 9541
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_get_T_0;

		// Token: 0x04002546 RID: 9542
		private static readonly IntPtr NativeMethodInfoPtr_set_Value_Public_set_Void_T_0;

		// Token: 0x04002547 RID: 9543
		private static readonly IntPtr NativeMethodInfoPtr_System_Threading_IAsyncLocal_OnValueChanged_Private_Virtual_Final_New_Void_Object_Object_Boolean_0;
	}
}
