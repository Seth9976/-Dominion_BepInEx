using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Collections
{
	// Token: 0x0200047E RID: 1150
	public class IList : Il2CppObjectBase
	{
		// Token: 0x060044AE RID: 17582 RVA: 0x00139D24 File Offset: 0x00137F24
		// Note: this type is marked as 'beforefieldinit'.
		static IList()
		{
			Il2CppClassPointerStore<IList>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections", "IList");
			IList.NativeMethodInfoPtr_get_Item_Public_Abstract_Virtual_New_get_Object_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IList>.NativeClassPtr, 100673300);
			IList.NativeMethodInfoPtr_set_Item_Public_Abstract_Virtual_New_set_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IList>.NativeClassPtr, 100673301);
			IList.NativeMethodInfoPtr_Add_Public_Abstract_Virtual_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IList>.NativeClassPtr, 100673302);
			IList.NativeMethodInfoPtr_Contains_Public_Abstract_Virtual_New_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IList>.NativeClassPtr, 100673303);
			IList.NativeMethodInfoPtr_Clear_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IList>.NativeClassPtr, 100673304);
			IList.NativeMethodInfoPtr_get_IsReadOnly_Public_Abstract_Virtual_New_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IList>.NativeClassPtr, 100673305);
			IList.NativeMethodInfoPtr_IndexOf_Public_Abstract_Virtual_New_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IList>.NativeClassPtr, 100673306);
			IList.NativeMethodInfoPtr_Insert_Public_Abstract_Virtual_New_Void_Int32_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IList>.NativeClassPtr, 100673307);
			IList.NativeMethodInfoPtr_Remove_Public_Abstract_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IList>.NativeClassPtr, 100673308);
			IList.NativeMethodInfoPtr_RemoveAt_Public_Abstract_Virtual_New_Void_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IList>.NativeClassPtr, 100673309);
		}

		// Token: 0x1700117F RID: 4479
		public unsafe virtual Object this[int index]
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IList.NativeMethodInfoPtr_get_Item_Public_Abstract_Virtual_New_get_Object_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
					IntPtr intPtr3 = intPtr;
					return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
				}
			}
			[CallerCount(0)]
			set
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref index;
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IList.NativeMethodInfoPtr_set_Item_Public_Abstract_Virtual_New_set_Void_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060044B1 RID: 17585 RVA: 0x00139EC8 File Offset: 0x001380C8
		[CallerCount(0)]
		public unsafe virtual int Add(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IList.NativeMethodInfoPtr_Add_Public_Abstract_Virtual_New_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060044B2 RID: 17586 RVA: 0x00139F20 File Offset: 0x00138120
		[CallerCount(0)]
		public unsafe virtual bool Contains(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IList.NativeMethodInfoPtr_Contains_Public_Abstract_Virtual_New_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060044B3 RID: 17587 RVA: 0x00139F78 File Offset: 0x00138178
		[CallerCount(0)]
		public unsafe virtual void Clear()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IList.NativeMethodInfoPtr_Clear_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x17001180 RID: 4480
		// (get) Token: 0x060044B4 RID: 17588 RVA: 0x00139FB4 File Offset: 0x001381B4
		public unsafe virtual bool IsReadOnly
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IList.NativeMethodInfoPtr_get_IsReadOnly_Public_Abstract_Virtual_New_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060044B5 RID: 17589 RVA: 0x00139FFC File Offset: 0x001381FC
		[CallerCount(0)]
		public unsafe virtual int IndexOf(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IList.NativeMethodInfoPtr_IndexOf_Public_Abstract_Virtual_New_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060044B6 RID: 17590 RVA: 0x0013A054 File Offset: 0x00138254
		[CallerCount(0)]
		public unsafe virtual void Insert(int index, Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IList.NativeMethodInfoPtr_Insert_Public_Abstract_Virtual_New_Void_Int32_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044B7 RID: 17591 RVA: 0x0013A0B0 File Offset: 0x001382B0
		[CallerCount(0)]
		public unsafe virtual void Remove(Object value)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IList.NativeMethodInfoPtr_Remove_Public_Abstract_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060044B8 RID: 17592 RVA: 0x0013A100 File Offset: 0x00138300
		[CallerCount(0)]
		public unsafe virtual void RemoveAt(int index)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref index;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IList.NativeMethodInfoPtr_RemoveAt_Public_Abstract_Virtual_New_Void_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x060044B9 RID: 17593 RVA: 0x0001A51C File Offset: 0x0001871C
		public IList(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040037E0 RID: 14304
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Abstract_Virtual_New_get_Object_Int32_0;

		// Token: 0x040037E1 RID: 14305
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_Abstract_Virtual_New_set_Void_Int32_Object_0;

		// Token: 0x040037E2 RID: 14306
		private static readonly IntPtr NativeMethodInfoPtr_Add_Public_Abstract_Virtual_New_Int32_Object_0;

		// Token: 0x040037E3 RID: 14307
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Abstract_Virtual_New_Boolean_Object_0;

		// Token: 0x040037E4 RID: 14308
		private static readonly IntPtr NativeMethodInfoPtr_Clear_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x040037E5 RID: 14309
		private static readonly IntPtr NativeMethodInfoPtr_get_IsReadOnly_Public_Abstract_Virtual_New_get_Boolean_0;

		// Token: 0x040037E6 RID: 14310
		private static readonly IntPtr NativeMethodInfoPtr_IndexOf_Public_Abstract_Virtual_New_Int32_Object_0;

		// Token: 0x040037E7 RID: 14311
		private static readonly IntPtr NativeMethodInfoPtr_Insert_Public_Abstract_Virtual_New_Void_Int32_Object_0;

		// Token: 0x040037E8 RID: 14312
		private static readonly IntPtr NativeMethodInfoPtr_Remove_Public_Abstract_Virtual_New_Void_Object_0;

		// Token: 0x040037E9 RID: 14313
		private static readonly IntPtr NativeMethodInfoPtr_RemoveAt_Public_Abstract_Virtual_New_Void_Int32_0;
	}
}
