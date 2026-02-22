using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Collections
{
	// Token: 0x02000479 RID: 1145
	public class IDictionaryEnumerator : Il2CppObjectBase
	{
		// Token: 0x0600449A RID: 17562 RVA: 0x001398F8 File Offset: 0x00137AF8
		// Note: this type is marked as 'beforefieldinit'.
		static IDictionaryEnumerator()
		{
			Il2CppClassPointerStore<IDictionaryEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections", "IDictionaryEnumerator");
			IDictionaryEnumerator.NativeMethodInfoPtr_get_Key_Public_Abstract_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDictionaryEnumerator>.NativeClassPtr, 100673290);
			IDictionaryEnumerator.NativeMethodInfoPtr_get_Value_Public_Abstract_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDictionaryEnumerator>.NativeClassPtr, 100673291);
			IDictionaryEnumerator.NativeMethodInfoPtr_get_Entry_Public_Abstract_Virtual_New_get_DictionaryEntry_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IDictionaryEnumerator>.NativeClassPtr, 100673292);
		}

		// Token: 0x1700117B RID: 4475
		// (get) Token: 0x0600449B RID: 17563 RVA: 0x0013995C File Offset: 0x00137B5C
		public unsafe virtual Object Key
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDictionaryEnumerator.NativeMethodInfoPtr_get_Key_Public_Abstract_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x1700117C RID: 4476
		// (get) Token: 0x0600449C RID: 17564 RVA: 0x001399A8 File Offset: 0x00137BA8
		public unsafe virtual Object Value
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDictionaryEnumerator.NativeMethodInfoPtr_get_Value_Public_Abstract_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x1700117D RID: 4477
		// (get) Token: 0x0600449D RID: 17565 RVA: 0x001399F4 File Offset: 0x00137BF4
		public unsafe virtual DictionaryEntry Entry
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IDictionaryEnumerator.NativeMethodInfoPtr_get_Entry_Public_Abstract_Virtual_New_get_DictionaryEntry_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return new DictionaryEntry(intPtr);
			}
		}

		// Token: 0x0600449E RID: 17566 RVA: 0x0001A491 File Offset: 0x00018691
		public IDictionaryEnumerator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040037D6 RID: 14294
		private static readonly IntPtr NativeMethodInfoPtr_get_Key_Public_Abstract_Virtual_New_get_Object_0;

		// Token: 0x040037D7 RID: 14295
		private static readonly IntPtr NativeMethodInfoPtr_get_Value_Public_Abstract_Virtual_New_get_Object_0;

		// Token: 0x040037D8 RID: 14296
		private static readonly IntPtr NativeMethodInfoPtr_get_Entry_Public_Abstract_Virtual_New_get_DictionaryEntry_0;
	}
}
