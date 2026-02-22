using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;

namespace Il2CppSystem.Runtime.InteropServices
{
	// Token: 0x02000454 RID: 1108
	public class ICustomMarshaler : Il2CppObjectBase
	{
		// Token: 0x060042FC RID: 17148 RVA: 0x001333E8 File Offset: 0x001315E8
		// Note: this type is marked as 'beforefieldinit'.
		static ICustomMarshaler()
		{
			Il2CppClassPointerStore<ICustomMarshaler>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.InteropServices", "ICustomMarshaler");
			ICustomMarshaler.NativeMethodInfoPtr_MarshalNativeToManaged_Public_Abstract_Virtual_New_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICustomMarshaler>.NativeClassPtr, 100672988);
			ICustomMarshaler.NativeMethodInfoPtr_MarshalManagedToNative_Public_Abstract_Virtual_New_IntPtr_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICustomMarshaler>.NativeClassPtr, 100672989);
			ICustomMarshaler.NativeMethodInfoPtr_CleanUpNativeData_Public_Abstract_Virtual_New_Void_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICustomMarshaler>.NativeClassPtr, 100672990);
			ICustomMarshaler.NativeMethodInfoPtr_CleanUpManagedData_Public_Abstract_Virtual_New_Void_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICustomMarshaler>.NativeClassPtr, 100672991);
			ICustomMarshaler.NativeMethodInfoPtr_GetNativeDataSize_Public_Abstract_Virtual_New_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ICustomMarshaler>.NativeClassPtr, 100672992);
		}

		// Token: 0x060042FD RID: 17149 RVA: 0x00133474 File Offset: 0x00131674
		[CallerCount(0)]
		public unsafe virtual Object MarshalNativeToManaged(IntPtr pNativeData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pNativeData;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICustomMarshaler.NativeMethodInfoPtr_MarshalNativeToManaged_Public_Abstract_Virtual_New_Object_IntPtr_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Object>(intPtr3) : null;
			}
		}

		// Token: 0x060042FE RID: 17150 RVA: 0x001334CC File Offset: 0x001316CC
		[CallerCount(0)]
		public unsafe virtual IntPtr MarshalManagedToNative(Object ManagedObj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ManagedObj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICustomMarshaler.NativeMethodInfoPtr_MarshalManagedToNative_Public_Abstract_Virtual_New_IntPtr_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060042FF RID: 17151 RVA: 0x00133524 File Offset: 0x00131724
		[CallerCount(0)]
		public unsafe virtual void CleanUpNativeData(IntPtr pNativeData)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref pNativeData;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICustomMarshaler.NativeMethodInfoPtr_CleanUpNativeData_Public_Abstract_Virtual_New_Void_IntPtr_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004300 RID: 17152 RVA: 0x00133570 File Offset: 0x00131770
		[CallerCount(0)]
		public unsafe virtual void CleanUpManagedData(Object ManagedObj)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(ManagedObj);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICustomMarshaler.NativeMethodInfoPtr_CleanUpManagedData_Public_Abstract_Virtual_New_Void_Object_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06004301 RID: 17153 RVA: 0x001335C0 File Offset: 0x001317C0
		[CallerCount(0)]
		public unsafe virtual int GetNativeDataSize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ICustomMarshaler.NativeMethodInfoPtr_GetNativeDataSize_Public_Abstract_Virtual_New_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06004302 RID: 17154 RVA: 0x00019BD0 File Offset: 0x00017DD0
		public ICustomMarshaler(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x040036B4 RID: 14004
		private static readonly IntPtr NativeMethodInfoPtr_MarshalNativeToManaged_Public_Abstract_Virtual_New_Object_IntPtr_0;

		// Token: 0x040036B5 RID: 14005
		private static readonly IntPtr NativeMethodInfoPtr_MarshalManagedToNative_Public_Abstract_Virtual_New_IntPtr_Object_0;

		// Token: 0x040036B6 RID: 14006
		private static readonly IntPtr NativeMethodInfoPtr_CleanUpNativeData_Public_Abstract_Virtual_New_Void_IntPtr_0;

		// Token: 0x040036B7 RID: 14007
		private static readonly IntPtr NativeMethodInfoPtr_CleanUpManagedData_Public_Abstract_Virtual_New_Void_Object_0;

		// Token: 0x040036B8 RID: 14008
		private static readonly IntPtr NativeMethodInfoPtr_GetNativeDataSize_Public_Abstract_Virtual_New_Int32_0;
	}
}
