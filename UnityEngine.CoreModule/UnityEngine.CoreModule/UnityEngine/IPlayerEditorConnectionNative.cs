using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x0200008B RID: 139
	public class IPlayerEditorConnectionNative : Il2CppObjectBase
	{
		// Token: 0x06000EED RID: 3821 RVA: 0x0003E684 File Offset: 0x0003C884
		// Note: this type is marked as 'beforefieldinit'.
		static IPlayerEditorConnectionNative()
		{
			Il2CppClassPointerStore<IPlayerEditorConnectionNative>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "IPlayerEditorConnectionNative");
			IPlayerEditorConnectionNative.NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayerEditorConnectionNative>.NativeClassPtr, 100664216);
			IPlayerEditorConnectionNative.NativeMethodInfoPtr_DisconnectAll_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayerEditorConnectionNative>.NativeClassPtr, 100664217);
			IPlayerEditorConnectionNative.NativeMethodInfoPtr_SendMessage_Public_Abstract_Virtual_New_Void_Guid_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayerEditorConnectionNative>.NativeClassPtr, 100664218);
			IPlayerEditorConnectionNative.NativeMethodInfoPtr_TrySendMessage_Public_Abstract_Virtual_New_Boolean_Guid_Il2CppStructArray_1_Byte_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayerEditorConnectionNative>.NativeClassPtr, 100664219);
			IPlayerEditorConnectionNative.NativeMethodInfoPtr_Poll_Public_Abstract_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayerEditorConnectionNative>.NativeClassPtr, 100664220);
			IPlayerEditorConnectionNative.NativeMethodInfoPtr_RegisterInternal_Public_Abstract_Virtual_New_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayerEditorConnectionNative>.NativeClassPtr, 100664221);
			IPlayerEditorConnectionNative.NativeMethodInfoPtr_UnregisterInternal_Public_Abstract_Virtual_New_Void_Guid_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayerEditorConnectionNative>.NativeClassPtr, 100664222);
			IPlayerEditorConnectionNative.NativeMethodInfoPtr_IsConnected_Public_Abstract_Virtual_New_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IPlayerEditorConnectionNative>.NativeClassPtr, 100664223);
		}

		// Token: 0x06000EEE RID: 3822 RVA: 0x0003E74C File Offset: 0x0003C94C
		[CallerCount(0)]
		public unsafe virtual void Initialize()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayerEditorConnectionNative.NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EEF RID: 3823 RVA: 0x0003E788 File Offset: 0x0003C988
		[CallerCount(0)]
		public unsafe virtual void DisconnectAll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayerEditorConnectionNative.NativeMethodInfoPtr_DisconnectAll_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EF0 RID: 3824 RVA: 0x0003E7C4 File Offset: 0x0003C9C4
		[CallerCount(0)]
		public unsafe virtual void SendMessage(Guid messageId, Il2CppStructArray<byte> data, int playerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref messageId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playerId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayerEditorConnectionNative.NativeMethodInfoPtr_SendMessage_Public_Abstract_Virtual_New_Void_Guid_Il2CppStructArray_1_Byte_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EF1 RID: 3825 RVA: 0x0003E830 File Offset: 0x0003CA30
		[CallerCount(0)]
		public unsafe virtual bool TrySendMessage(Guid messageId, Il2CppStructArray<byte> data, int playerId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref messageId;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(data);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref playerId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayerEditorConnectionNative.NativeMethodInfoPtr_TrySendMessage_Public_Abstract_Virtual_New_Boolean_Guid_Il2CppStructArray_1_Byte_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EF2 RID: 3826 RVA: 0x0003E8A4 File Offset: 0x0003CAA4
		[CallerCount(0)]
		public unsafe virtual void Poll()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayerEditorConnectionNative.NativeMethodInfoPtr_Poll_Public_Abstract_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000EF3 RID: 3827 RVA: 0x0003E8E0 File Offset: 0x0003CAE0
		[CallerCount(0)]
		public unsafe virtual void RegisterInternal(Guid messageId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref messageId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayerEditorConnectionNative.NativeMethodInfoPtr_RegisterInternal_Public_Abstract_Virtual_New_Void_Guid_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000EF4 RID: 3828 RVA: 0x0003E92C File Offset: 0x0003CB2C
		[CallerCount(0)]
		public unsafe virtual void UnregisterInternal(Guid messageId)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref messageId;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayerEditorConnectionNative.NativeMethodInfoPtr_UnregisterInternal_Public_Abstract_Virtual_New_Void_Guid_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000EF5 RID: 3829 RVA: 0x0003E978 File Offset: 0x0003CB78
		[CallerCount(0)]
		public unsafe virtual bool IsConnected()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IPlayerEditorConnectionNative.NativeMethodInfoPtr_IsConnected_Public_Abstract_Virtual_New_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000EF6 RID: 3830 RVA: 0x00009950 File Offset: 0x00007B50
		public IPlayerEditorConnectionNative(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000B88 RID: 2952
		private static readonly IntPtr NativeMethodInfoPtr_Initialize_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04000B89 RID: 2953
		private static readonly IntPtr NativeMethodInfoPtr_DisconnectAll_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04000B8A RID: 2954
		private static readonly IntPtr NativeMethodInfoPtr_SendMessage_Public_Abstract_Virtual_New_Void_Guid_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04000B8B RID: 2955
		private static readonly IntPtr NativeMethodInfoPtr_TrySendMessage_Public_Abstract_Virtual_New_Boolean_Guid_Il2CppStructArray_1_Byte_Int32_0;

		// Token: 0x04000B8C RID: 2956
		private static readonly IntPtr NativeMethodInfoPtr_Poll_Public_Abstract_Virtual_New_Void_0;

		// Token: 0x04000B8D RID: 2957
		private static readonly IntPtr NativeMethodInfoPtr_RegisterInternal_Public_Abstract_Virtual_New_Void_Guid_0;

		// Token: 0x04000B8E RID: 2958
		private static readonly IntPtr NativeMethodInfoPtr_UnregisterInternal_Public_Abstract_Virtual_New_Void_Guid_0;

		// Token: 0x04000B8F RID: 2959
		private static readonly IntPtr NativeMethodInfoPtr_IsConnected_Public_Abstract_Virtual_New_Boolean_0;
	}
}
