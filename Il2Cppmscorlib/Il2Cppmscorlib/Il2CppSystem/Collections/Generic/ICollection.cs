using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;

namespace Il2CppSystem.Collections.Generic
{
	// Token: 0x020004A7 RID: 1191
	public class ICollection<T> : Il2CppObjectBase
	{
		// Token: 0x060046B7 RID: 18103 RVA: 0x00144EC0 File Offset: 0x001430C0
		// Note: this type is marked as 'beforefieldinit'.
		static ICollection()
		{
			Il2CppClassPointerStore<ICollection<T>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections.Generic", "ICollection`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) })).TypeHandle.value);
			ICollection<T>.NativeMethodInfoPtr_get_Count_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICollection<T>>.NativeClassPtr, 100673782);
			ICollection<T>.NativeMethodInfoPtr_get_IsReadOnly_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICollection<T>>.NativeClassPtr, 100673783);
			ICollection<T>.NativeMethodInfoPtr_Add_Public_Abstract_Virtual_New_Void_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICollection<T>>.NativeClassPtr, 100673784);
			ICollection<T>.NativeMethodInfoPtr_Clear_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICollection<T>>.NativeClassPtr, 100673785);
			ICollection<T>.NativeMethodInfoPtr_Contains_Public_Abstract_Virtual_New_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICollection<T>>.NativeClassPtr, 100673786);
			ICollection<T>.NativeMethodInfoPtr_CopyTo_Public_Abstract_Virtual_New_Void_Il2CppArrayBase_1_T_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICollection<T>>.NativeClassPtr, 100673787);
			ICollection<T>.NativeMethodInfoPtr_Remove_Public_Abstract_Virtual_New_Boolean_T_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICollection<T>>.NativeClassPtr, 100673788);
		}

		// Token: 0x170011DF RID: 4575
		// (get) Token: 0x060046B8 RID: 18104 RVA: 0x00144FB0 File Offset: 0x001431B0
		public unsafe virtual int Count
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICollection<T>.NativeMethodInfoPtr_get_Count_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x170011E0 RID: 4576
		// (get) Token: 0x060046B9 RID: 18105 RVA: 0x00144FF8 File Offset: 0x001431F8
		public unsafe virtual bool IsReadOnly
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICollection<T>.NativeMethodInfoPtr_get_IsReadOnly_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060046BA RID: 18106 RVA: 0x00145040 File Offset: 0x00143240
		[CallerCount(0)]
		public unsafe virtual void Add(T item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = item;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref item;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICollection<T>.NativeMethodInfoPtr_Add_Public_Abstract_Virtual_New_Void_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
			}
		}

		// Token: 0x060046BB RID: 18107 RVA: 0x001450C4 File Offset: 0x001432C4
		[CallerCount(0)]
		public unsafe virtual void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICollection<T>.NativeMethodInfoPtr_Clear_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060046BC RID: 18108 RVA: 0x00145100 File Offset: 0x00143300
		[CallerCount(0)]
		public unsafe virtual bool Contains(T item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = item;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref item;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICollection<T>.NativeMethodInfoPtr_Contains_Public_Abstract_Virtual_New_Boolean_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x060046BD RID: 18109 RVA: 0x00145190 File Offset: 0x00143390
		[CallerCount(0)]
		public unsafe virtual void CopyTo(Il2CppArrayBase<T> array, int arrayIndex)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(array);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref arrayIndex;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICollection<T>.NativeMethodInfoPtr_CopyTo_Public_Abstract_Virtual_New_Void_Il2CppArrayBase_1_T_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060046BE RID: 18110 RVA: 0x001451EC File Offset: 0x001433EC
		[CallerCount(0)]
		public unsafe virtual bool Remove(T item)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				ref IntPtr ptr2 = ref *ptr;
				IntPtr intPtr;
				if (!typeof(T).IsValueType)
				{
					T t = item;
					intPtr = ((t is string) ? IL2CPP.ManagedStringToIl2Cpp(t as string) : IL2CPP.Il2CppObjectBaseToPtr(t as Il2CppObjectBase));
				}
				else
				{
					intPtr = ref item;
				}
				ptr2 = intPtr;
				IntPtr intPtr3;
				IntPtr intPtr2 = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICollection<T>.NativeMethodInfoPtr_Remove_Public_Abstract_Virtual_New_Boolean_T_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr3);
				Il2CppException.RaiseExceptionIfNecessary(intPtr3);
				return *IL2CPP.il2cpp_object_unbox(intPtr2);
			}
		}

		// Token: 0x060046BF RID: 18111 RVA: 0x0001AC17 File Offset: 0x00018E17
		public ICollection(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003968 RID: 14696
		private static readonly IntPtr NativeMethodInfoPtr_get_Count_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x04003969 RID: 14697
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x0400396A RID: 14698
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Abstract_Virtual_New_Void_T_0;

		// Token: 0x0400396B RID: 14699
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x0400396C RID: 14700
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Abstract_Virtual_New_Boolean_T_0;

		// Token: 0x0400396D RID: 14701
		private static readonly IntPtr NativeMethodInfoPtr_CopyTo_Public_Abstract_Virtual_New_Void_Il2CppArrayBase_1_T_Int32_0;

		// Token: 0x0400396E RID: 14702
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Abstract_Virtual_New_Boolean_T_0;
	}
}
