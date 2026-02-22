using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Collections
{
	// Token: 0x0200047B RID: 1147
	public class IEnumerator : Il2CppObjectBase
	{
		// Token: 0x060044A2 RID: 17570 RVA: 0x00139A84 File Offset: 0x00137C84
		// Note: this type is marked as 'beforefieldinit'.
		static IEnumerator()
		{
			Il2CppClassPointerStore<IEnumerator>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Collections", "IEnumerator");
			IEnumerator.NativeMethodInfoPtr_MoveNext_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEnumerator>.NativeClassPtr, 100673294);
			IEnumerator.NativeMethodInfoPtr_get_Current_Public_Abstract_Virtual_New_get_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEnumerator>.NativeClassPtr, 100673295);
			IEnumerator.NativeMethodInfoPtr_Reset_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IEnumerator>.NativeClassPtr, 100673296);
		}

		// Token: 0x060044A3 RID: 17571 RVA: 0x00139AE8 File Offset: 0x00137CE8
		[CallerCount(0)]
		public unsafe virtual bool MoveNext()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IEnumerator.NativeMethodInfoPtr_MoveNext_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x1700117E RID: 4478
		// (get) Token: 0x060044A4 RID: 17572 RVA: 0x00139B30 File Offset: 0x00137D30
		public unsafe virtual Object Current
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IEnumerator.NativeMethodInfoPtr_get_Current_Public_Abstract_Virtual_New_get_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060044A5 RID: 17573 RVA: 0x00139B7C File Offset: 0x00137D7C
		[CallerCount(0)]
		public unsafe virtual void Reset()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IEnumerator.NativeMethodInfoPtr_Reset_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060044A6 RID: 17574 RVA: 0x0001A4D2 File Offset: 0x000186D2
		public IEnumerator(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040037DA RID: 14298
		private static readonly IntPtr NativeMethodInfoPtr_MoveNext_Public_Abstract_Virtual_New_Boolean_0;

		// Token: 0x040037DB RID: 14299
		private static readonly IntPtr NativeMethodInfoPtr_get_Current_Public_Abstract_Virtual_New_get_Object_0;

		// Token: 0x040037DC RID: 14300
		private static readonly IntPtr NativeMethodInfoPtr_Reset_Public_Abstract_Virtual_New_Void_0;
	}
}
