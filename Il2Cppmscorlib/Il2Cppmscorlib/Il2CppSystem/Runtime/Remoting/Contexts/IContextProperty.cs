using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;

namespace Il2CppSystem.Runtime.Remoting.Contexts
{
	// Token: 0x020003BA RID: 954
	public class IContextProperty : Il2CppObjectBase
	{
		// Token: 0x06003DDA RID: 15834 RVA: 0x00121BE8 File Offset: 0x0011FDE8
		// Note: this type is marked as 'beforefieldinit'.
		static IContextProperty()
		{
			Il2CppClassPointerStore<IContextProperty>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting.Contexts", "IContextProperty");
			IContextProperty.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IContextProperty>.NativeClassPtr, 100672398);
			IContextProperty.NativeMethodInfoPtr_Freeze_Public_Abstract_Virtual_New_Void_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IContextProperty>.NativeClassPtr, 100672399);
			IContextProperty.NativeMethodInfoPtr_IsNewContextOK_Public_Abstract_Virtual_New_Boolean_Context_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IContextProperty>.NativeClassPtr, 100672400);
		}

		// Token: 0x17000F85 RID: 3973
		// (get) Token: 0x06003DDB RID: 15835 RVA: 0x00121C4C File Offset: 0x0011FE4C
		public unsafe virtual string Name
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IContextProperty.NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x06003DDC RID: 15836 RVA: 0x00121C90 File Offset: 0x0011FE90
		[CallerCount(0)]
		public unsafe virtual void Freeze(Context newContext)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newContext);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IContextProperty.NativeMethodInfoPtr_Freeze_Public_Abstract_Virtual_New_Void_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06003DDD RID: 15837 RVA: 0x00121CE0 File Offset: 0x0011FEE0
		[CallerCount(0)]
		public unsafe virtual bool IsNewContextOK(Context newCtx)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(newCtx);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IContextProperty.NativeMethodInfoPtr_IsNewContextOK_Public_Abstract_Virtual_New_Boolean_Context_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06003DDE RID: 15838 RVA: 0x0001744D File Offset: 0x0001564D
		public IContextProperty(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04003321 RID: 13089
		private static readonly IntPtr NativeMethodInfoPtr_get_Name_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04003322 RID: 13090
		private static readonly IntPtr NativeMethodInfoPtr_Freeze_Public_Abstract_Virtual_New_Void_Context_0;

		// Token: 0x04003323 RID: 13091
		private static readonly IntPtr NativeMethodInfoPtr_IsNewContextOK_Public_Abstract_Virtual_New_Boolean_Context_0;
	}
}
