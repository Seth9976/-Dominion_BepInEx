using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Collections
{
	// Token: 0x02000478 RID: 1144
	public class IDictionary : Il2CppObjectBase
	{
		// Token: 0x06004493 RID: 17555 RVA: 0x001396C0 File Offset: 0x001378C0
		// Note: this type is marked as 'beforefieldinit'.
		static IDictionary()
		{
			Il2CppClassPointerStore<IDictionary>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections", "IDictionary");
			IDictionary.NativeMethodInfoPtr_get_Item_Public_Abstract_Virtual_New_get_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDictionary>.NativeClassPtr, 100673285);
			IDictionary.NativeMethodInfoPtr_set_Item_Public_Abstract_Virtual_New_set_Void_Object_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDictionary>.NativeClassPtr, 100673286);
			IDictionary.NativeMethodInfoPtr_get_Keys_Public_Abstract_Virtual_New_get_ICollection_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDictionary>.NativeClassPtr, 100673287);
			IDictionary.NativeMethodInfoPtr_Contains_Public_Abstract_Virtual_New_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDictionary>.NativeClassPtr, 100673288);
			IDictionary.NativeMethodInfoPtr_GetEnumerator_Public_Abstract_Virtual_New_IDictionaryEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDictionary>.NativeClassPtr, 100673289);
		}

		// Token: 0x17001179 RID: 4473
		public unsafe virtual Object this[Object key]
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDictionary.NativeMethodInfoPtr_get_Item_Public_Abstract_Virtual_New_get_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
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
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(value);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDictionary.NativeMethodInfoPtr_set_Item_Public_Abstract_Virtual_New_set_Void_Object_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x1700117A RID: 4474
		// (get) Token: 0x06004496 RID: 17558 RVA: 0x00139808 File Offset: 0x00137A08
		public unsafe virtual ICollection Keys
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDictionary.NativeMethodInfoPtr_get_Keys_Public_Abstract_Virtual_New_get_ICollection_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<ICollection>(intPtr3) : null;
			}
		}

		// Token: 0x06004497 RID: 17559 RVA: 0x00139854 File Offset: 0x00137A54
		[CallerCount(0)]
		public unsafe virtual bool Contains(Object key)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(key);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDictionary.NativeMethodInfoPtr_Contains_Public_Abstract_Virtual_New_Boolean_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06004498 RID: 17560 RVA: 0x001398AC File Offset: 0x00137AAC
		[CallerCount(0)]
		public unsafe virtual IDictionaryEnumerator GetEnumerator()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDictionary.NativeMethodInfoPtr_GetEnumerator_Public_Abstract_Virtual_New_IDictionaryEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<IDictionaryEnumerator>(intPtr3) : null;
		}

		// Token: 0x06004499 RID: 17561 RVA: 0x0001A488 File Offset: 0x00018688
		public IDictionary(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040037D1 RID: 14289
		private static readonly IntPtr NativeMethodInfoPtr_get_Item_Public_Abstract_Virtual_New_get_Object_Object_0;

		// Token: 0x040037D2 RID: 14290
		private static readonly IntPtr NativeMethodInfoPtr_set_Item_Public_Abstract_Virtual_New_set_Void_Object_Object_0;

		// Token: 0x040037D3 RID: 14291
		private static readonly IntPtr NativeMethodInfoPtr_get_Keys_Public_Abstract_Virtual_New_get_ICollection_0;

		// Token: 0x040037D4 RID: 14292
		private static readonly IntPtr NativeMethodInfoPtr_Contains_Public_Abstract_Virtual_New_Boolean_Object_0;

		// Token: 0x040037D5 RID: 14293
		private static readonly IntPtr NativeMethodInfoPtr_GetEnumerator_Public_Abstract_Virtual_New_IDictionaryEnumerator_0;
	}
}
