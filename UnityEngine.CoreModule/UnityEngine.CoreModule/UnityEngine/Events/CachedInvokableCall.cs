using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.Events
{
	// Token: 0x02000101 RID: 257
	public class CachedInvokableCall<T> : InvokableCall<T>
	{
		// Token: 0x06001596 RID: 5526 RVA: 0x00052388 File Offset: 0x00050588
		// Note: this type is marked as 'beforefieldinit'.
		static CachedInvokableCall()
		{
			Il2CppClassPointerStore<CachedInvokableCall<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Events", "CachedInvokableCall`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CachedInvokableCall<T>>.NativeClassPtr);
			CachedInvokableCall<T>.NativeFieldInfoPtr_m_Arg1 = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CachedInvokableCall<T>>.NativeClassPtr, "m_Arg1");
			CachedInvokableCall<T>.NativeMethodInfoPtr__ctor_Public_Void_Object_MethodInfo_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CachedInvokableCall<T>>.NativeClassPtr, 100664894);
			CachedInvokableCall<T>.NativeMethodInfoPtr_Invoke_Public_Virtual_Void_Il2CppReferenceArray_1_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CachedInvokableCall<T>>.NativeClassPtr, 100664895);
			CachedInvokableCall<T>.NativeMethodInfoPtr_Invoke_Public_Virtual_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CachedInvokableCall<T>>.NativeClassPtr, 100664896);
		}

		// Token: 0x06001597 RID: 5527 RVA: 0x00052444 File Offset: 0x00050644
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 80202, RefRangeEnd = 80203, XrefRangeStart = 80202, XrefRangeEnd = 80202, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CachedInvokableCall(Object target, MethodInfo theFunction, T argument)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CachedInvokableCall<T>>.NativeClassPtr))
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(target);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(theFunction);
			ref IntPtr ptr2 = ref ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)];
			IntPtr intPtr;
			if (!typeof(T).IsValueType)
			{
				T t = argument;
				intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
			}
			else
			{
				intPtr = ref argument;
			}
			ptr2 = intPtr;
			IntPtr intPtr3;
			IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(CachedInvokableCall<T>.NativeMethodInfoPtr__ctor_Public_Void_Object_MethodInfo_T_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
			Il2CppException.RaiseExceptionIfNecessary(intPtr3);
		}

		// Token: 0x06001598 RID: 5528 RVA: 0x000524EC File Offset: 0x000506EC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 80203, XrefRangeEnd = 80206, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Invoke(Il2CppReferenceArray<Object> args)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(args);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CachedInvokableCall<T>.NativeMethodInfoPtr_Invoke_Public_Virtual_Void_Il2CppReferenceArray_1_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001599 RID: 5529 RVA: 0x0005253C File Offset: 0x0005073C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override void Invoke(T arg0)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = arg0;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref arg0;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), CachedInvokableCall<T>.NativeMethodInfoPtr_Invoke_Public_Virtual_Void_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x0600159A RID: 5530 RVA: 0x0000C50F File Offset: 0x0000A70F
		public CachedInvokableCall(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x0600159B RID: 5531 RVA: 0x000525C0 File Offset: 0x000507C0
		// (set) Token: 0x0600159C RID: 5532 RVA: 0x000525E8 File Offset: 0x000507E8
		public unsafe T m_Arg1
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CachedInvokableCall<T>.NativeFieldInfoPtr_m_Arg1);
				return IL2CPP.PointerToValueGeneric<T>(intPtr, true, false);
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr intPtr2 = intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CachedInvokableCall<T>.NativeFieldInfoPtr_m_Arg1);
				Type typeFromHandle = typeof(T);
				if (!typeFromHandle.IsValueType)
				{
					if (!string.Equals(typeFromHandle.FullName, "System.String"))
					{
						IntPtr intPtr4;
						IntPtr intPtr3 = (intPtr4 = IL2CPP.Il2CppObjectBaseToPtr(value as Il2CppObjectBase));
						if (intPtr3 != 0)
						{
							intPtr4 = intPtr3;
							if (IL2CPP.il2cpp_class_is_valuetype(IL2CPP.il2cpp_object_get_class(intPtr3)))
							{
								IntPtr intPtr5 = intPtr3;
								cpblk(intPtr2, IL2CPP.il2cpp_object_unbox(intPtr3), IL2CPP.il2cpp_class_value_size(IL2CPP.il2cpp_object_get_class(intPtr5), (UIntPtr)0));
								return;
							}
						}
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, intPtr4);
					}
					else
					{
						IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr2, IL2CPP.ManagedStringToIl2Cpp(value as string));
					}
				}
				else
				{
					*intPtr2 = value;
				}
			}
		}

		// Token: 0x04001007 RID: 4103
		private static readonly IntPtr NativeFieldInfoPtr_m_Arg1;

		// Token: 0x04001008 RID: 4104
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_MethodInfo_T_0;

		// Token: 0x04001009 RID: 4105
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_Void_Il2CppReferenceArray_1_Object_0;

		// Token: 0x0400100A RID: 4106
		private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_Void_T_0;
	}
}
