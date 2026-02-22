using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections;
using UnityEngine;

namespace Uniject
{
	// Token: 0x02000002 RID: 2
	public class IUtil : Il2CppObjectBase
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00005A5C File Offset: 0x00003C5C
		// Note: this type is marked as 'beforefieldinit'.
		static IUtil()
		{
			Il2CppClassPointerStore<IUtil>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.Purchasing.Stores.dll", "Uniject", "IUtil");
			IUtil.NativeMethodInfoPtr_get_platform_Public_Abstract_Virtual_New_get_RuntimePlatform_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUtil>.NativeClassPtr, 100663297);
			IUtil.NativeMethodInfoPtr_get_persistentDataPath_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUtil>.NativeClassPtr, 100663298);
			IUtil.NativeMethodInfoPtr_get_cloudProjectId_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUtil>.NativeClassPtr, 100663299);
			IUtil.NativeMethodInfoPtr_get_unityVersion_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUtil>.NativeClassPtr, 100663300);
			IUtil.NativeMethodInfoPtr_get_userId_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUtil>.NativeClassPtr, 100663301);
			IUtil.NativeMethodInfoPtr_get_gameVersion_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUtil>.NativeClassPtr, 100663302);
			IUtil.NativeMethodInfoPtr_get_sessionId_Public_Abstract_Virtual_New_get_UInt64_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUtil>.NativeClassPtr, 100663303);
			IUtil.NativeMethodInfoPtr_get_operatingSystem_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUtil>.NativeClassPtr, 100663304);
			IUtil.NativeMethodInfoPtr_get_screenWidth_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUtil>.NativeClassPtr, 100663305);
			IUtil.NativeMethodInfoPtr_get_screenHeight_Public_Abstract_Virtual_New_get_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUtil>.NativeClassPtr, 100663306);
			IUtil.NativeMethodInfoPtr_get_screenDpi_Public_Abstract_Virtual_New_get_Single_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUtil>.NativeClassPtr, 100663307);
			IUtil.NativeMethodInfoPtr_get_screenOrientation_Public_Abstract_Virtual_New_get_String_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUtil>.NativeClassPtr, 100663308);
			IUtil.NativeMethodInfoPtr_InitiateCoroutine_Public_Abstract_Virtual_New_Object_IEnumerator_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUtil>.NativeClassPtr, 100663309);
			IUtil.NativeMethodInfoPtr_InitiateCoroutine_Public_Abstract_Virtual_New_Void_IEnumerator_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUtil>.NativeClassPtr, 100663310);
			IUtil.NativeMethodInfoPtr_RunOnMainThread_Public_Abstract_Virtual_New_Void_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUtil>.NativeClassPtr, 100663311);
			IUtil.NativeMethodInfoPtr_AddPauseListener_Public_Abstract_Virtual_New_Void_Action_1_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUtil>.NativeClassPtr, 100663312);
			IUtil.NativeMethodInfoPtr_IsClassOrSubclass_Public_Abstract_Virtual_New_Boolean_Type_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IUtil>.NativeClassPtr, 100663313);
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000002 RID: 2 RVA: 0x00005BD8 File Offset: 0x00003DD8
		public unsafe virtual RuntimePlatform platform
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUtil.NativeMethodInfoPtr_get_platform_Public_Abstract_Virtual_New_get_RuntimePlatform_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000003 RID: 3 RVA: 0x00005C20 File Offset: 0x00003E20
		public unsafe virtual string persistentDataPath
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUtil.NativeMethodInfoPtr_get_persistentDataPath_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000004 RID: 4 RVA: 0x00005C64 File Offset: 0x00003E64
		public unsafe virtual string cloudProjectId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUtil.NativeMethodInfoPtr_get_cloudProjectId_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000005 RID: 5 RVA: 0x00005CA8 File Offset: 0x00003EA8
		public unsafe virtual string unityVersion
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUtil.NativeMethodInfoPtr_get_unityVersion_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000006 RID: 6 RVA: 0x00005CEC File Offset: 0x00003EEC
		public unsafe virtual string userId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUtil.NativeMethodInfoPtr_get_userId_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000007 RID: 7 RVA: 0x00005D30 File Offset: 0x00003F30
		public unsafe virtual string gameVersion
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUtil.NativeMethodInfoPtr_get_gameVersion_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000008 RID: 8 RVA: 0x00005D74 File Offset: 0x00003F74
		public unsafe virtual ulong sessionId
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUtil.NativeMethodInfoPtr_get_sessionId_Public_Abstract_Virtual_New_get_UInt64_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000009 RID: 9 RVA: 0x00005DBC File Offset: 0x00003FBC
		public unsafe virtual string operatingSystem
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUtil.NativeMethodInfoPtr_get_operatingSystem_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600000A RID: 10 RVA: 0x00005E00 File Offset: 0x00004000
		public unsafe virtual int screenWidth
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUtil.NativeMethodInfoPtr_get_screenWidth_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600000B RID: 11 RVA: 0x00005E48 File Offset: 0x00004048
		public unsafe virtual int screenHeight
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUtil.NativeMethodInfoPtr_get_screenHeight_Public_Abstract_Virtual_New_get_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600000C RID: 12 RVA: 0x00005E90 File Offset: 0x00004090
		public unsafe virtual float screenDpi
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUtil.NativeMethodInfoPtr_get_screenDpi_Public_Abstract_Virtual_New_get_Single_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600000D RID: 13 RVA: 0x00005ED8 File Offset: 0x000040D8
		public unsafe virtual string screenOrientation
		{
			[CallerCount(0)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUtil.NativeMethodInfoPtr_get_screenOrientation_Public_Abstract_Virtual_New_get_String_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return IL2CPP.Il2CppStringToManaged(intPtr);
			}
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00005F1C File Offset: 0x0000411C
		[CallerCount(0)]
		public unsafe virtual global::Il2CppSystem.Object InitiateCoroutine(IEnumerator start)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(start);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUtil.NativeMethodInfoPtr_InitiateCoroutine_Public_Abstract_Virtual_New_Object_IEnumerator_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<global::Il2CppSystem.Object>(intPtr3) : null;
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00005F78 File Offset: 0x00004178
		[CallerCount(0)]
		public unsafe virtual void InitiateCoroutine(IEnumerator start, int delayInSeconds)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(start);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref delayInSeconds;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUtil.NativeMethodInfoPtr_InitiateCoroutine_Public_Abstract_Virtual_New_Void_IEnumerator_Int32_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00005FD4 File Offset: 0x000041D4
		[CallerCount(0)]
		public unsafe virtual void RunOnMainThread(Action runnable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(runnable);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUtil.NativeMethodInfoPtr_RunOnMainThread_Public_Abstract_Virtual_New_Void_Action_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00006024 File Offset: 0x00004224
		[CallerCount(0)]
		public unsafe virtual void AddPauseListener(Action<bool> runnable)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(runnable);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUtil.NativeMethodInfoPtr_AddPauseListener_Public_Abstract_Virtual_New_Void_Action_1_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00006074 File Offset: 0x00004274
		[CallerCount(0)]
		public unsafe virtual bool IsClassOrSubclass(Type potentialBase, Type potentialDescendant)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(potentialBase);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(potentialDescendant);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), IUtil.NativeMethodInfoPtr_IsClassOrSubclass_Public_Abstract_Virtual_New_Boolean_Type_Type_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002050 File Offset: 0x00000250
		public IUtil(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000001 RID: 1
		private static readonly IntPtr NativeMethodInfoPtr_get_platform_Public_Abstract_Virtual_New_get_RuntimePlatform_0;

		// Token: 0x04000002 RID: 2
		private static readonly IntPtr NativeMethodInfoPtr_get_persistentDataPath_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeMethodInfoPtr_get_cloudProjectId_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeMethodInfoPtr_get_unityVersion_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04000005 RID: 5
		private static readonly IntPtr NativeMethodInfoPtr_get_userId_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04000006 RID: 6
		private static readonly IntPtr NativeMethodInfoPtr_get_gameVersion_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04000007 RID: 7
		private static readonly IntPtr NativeMethodInfoPtr_get_sessionId_Public_Abstract_Virtual_New_get_UInt64_0;

		// Token: 0x04000008 RID: 8
		private static readonly IntPtr NativeMethodInfoPtr_get_operatingSystem_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x04000009 RID: 9
		private static readonly IntPtr NativeMethodInfoPtr_get_screenWidth_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x0400000A RID: 10
		private static readonly IntPtr NativeMethodInfoPtr_get_screenHeight_Public_Abstract_Virtual_New_get_Int32_0;

		// Token: 0x0400000B RID: 11
		private static readonly IntPtr NativeMethodInfoPtr_get_screenDpi_Public_Abstract_Virtual_New_get_Single_0;

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeMethodInfoPtr_get_screenOrientation_Public_Abstract_Virtual_New_get_String_0;

		// Token: 0x0400000D RID: 13
		private static readonly IntPtr NativeMethodInfoPtr_InitiateCoroutine_Public_Abstract_Virtual_New_Object_IEnumerator_0;

		// Token: 0x0400000E RID: 14
		private static readonly IntPtr NativeMethodInfoPtr_InitiateCoroutine_Public_Abstract_Virtual_New_Void_IEnumerator_Int32_0;

		// Token: 0x0400000F RID: 15
		private static readonly IntPtr NativeMethodInfoPtr_RunOnMainThread_Public_Abstract_Virtual_New_Void_Action_0;

		// Token: 0x04000010 RID: 16
		private static readonly IntPtr NativeMethodInfoPtr_AddPauseListener_Public_Abstract_Virtual_New_Void_Action_1_Boolean_0;

		// Token: 0x04000011 RID: 17
		private static readonly IntPtr NativeMethodInfoPtr_IsClassOrSubclass_Public_Abstract_Virtual_New_Boolean_Type_Type_0;
	}
}
