using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Text;

namespace Il2CppSystem
{
	// Token: 0x02000141 RID: 321
	public class ModifierSpec : Il2CppObjectBase
	{
		// Token: 0x060016AC RID: 5804 RVA: 0x00087F84 File Offset: 0x00086184
		// Note: this type is marked as 'beforefieldinit'.
		static ModifierSpec()
		{
			Il2CppClassPointerStore<ModifierSpec>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System", "ModifierSpec");
			ModifierSpec.NativeMethodInfoPtr_Resolve_Public_Abstract_Virtual_New_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifierSpec>.NativeClassPtr, 100667106);
			ModifierSpec.NativeMethodInfoPtr_Append_Public_Abstract_Virtual_New_StringBuilder_StringBuilder_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ModifierSpec>.NativeClassPtr, 100667107);
		}

		// Token: 0x060016AD RID: 5805 RVA: 0x00087FD4 File Offset: 0x000861D4
		[CallerCount(0)]
		public unsafe virtual Type Resolve(Type type)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(type);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ModifierSpec.NativeMethodInfoPtr_Resolve_Public_Abstract_Virtual_New_Type_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x060016AE RID: 5806 RVA: 0x00088030 File Offset: 0x00086230
		[CallerCount(0)]
		public unsafe virtual StringBuilder Append(StringBuilder sb)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sb);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ModifierSpec.NativeMethodInfoPtr_Append_Public_Abstract_Virtual_New_StringBuilder_StringBuilder_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<StringBuilder>(intPtr3) : null;
			}
		}

		// Token: 0x060016AF RID: 5807 RVA: 0x0000801B File Offset: 0x0000621B
		public ModifierSpec(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040014D3 RID: 5331
		private static readonly IntPtr NativeMethodInfoPtr_Resolve_Public_Abstract_Virtual_New_Type_Type_0;

		// Token: 0x040014D4 RID: 5332
		private static readonly IntPtr NativeMethodInfoPtr_Append_Public_Abstract_Virtual_New_StringBuilder_StringBuilder_0;
	}
}
