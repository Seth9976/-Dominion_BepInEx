using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Playables
{
	// Token: 0x02000153 RID: 339
	[StructLayout(2)]
	public struct PlayableOutputHandle
	{
		// Token: 0x06001A41 RID: 6721 RVA: 0x0005DE3C File Offset: 0x0005C03C
		// Note: this type is marked as 'beforefieldinit'.
		static PlayableOutputHandle()
		{
			Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Playables", "PlayableOutputHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr);
			PlayableOutputHandle.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, "m_Handle");
			PlayableOutputHandle.NativeFieldInfoPtr_m_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, "m_Version");
			PlayableOutputHandle.NativeFieldInfoPtr_m_Null = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, "m_Null");
			PlayableOutputHandle.NativeMethodInfoPtr_get_Null_Public_Static_get_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100665224);
			PlayableOutputHandle.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100665225);
			PlayableOutputHandle.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PlayableOutputHandle_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100665226);
			PlayableOutputHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100665227);
			PlayableOutputHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100665228);
			PlayableOutputHandle.NativeMethodInfoPtr_CompareVersion_Internal_Static_Boolean_PlayableOutputHandle_PlayableOutputHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, 100665229);
			PlayableOutputHandle.IsNull_InjectedDelegateField = IL2CPP.ResolveICall<PlayableOutputHandle.IsNull_InjectedDelegate>("UnityEngine.Playables.PlayableOutputHandle::IsNull_Injected");
			PlayableOutputHandle.IsValid_InjectedDelegateField = IL2CPP.ResolveICall<PlayableOutputHandle.IsValid_InjectedDelegate>("UnityEngine.Playables.PlayableOutputHandle::IsValid_Injected");
			PlayableOutputHandle.GetPlayableOutputType_InjectedDelegateField = IL2CPP.ResolveICall<PlayableOutputHandle.GetPlayableOutputType_InjectedDelegate>("UnityEngine.Playables.PlayableOutputHandle::GetPlayableOutputType_Injected");
			PlayableOutputHandle.GetReferenceObject_InjectedDelegateField = IL2CPP.ResolveICall<PlayableOutputHandle.GetReferenceObject_InjectedDelegate>("UnityEngine.Playables.PlayableOutputHandle::GetReferenceObject_Injected");
			PlayableOutputHandle.SetReferenceObject_InjectedDelegateField = IL2CPP.ResolveICall<PlayableOutputHandle.SetReferenceObject_InjectedDelegate>("UnityEngine.Playables.PlayableOutputHandle::SetReferenceObject_Injected");
			PlayableOutputHandle.GetUserData_InjectedDelegateField = IL2CPP.ResolveICall<PlayableOutputHandle.GetUserData_InjectedDelegate>("UnityEngine.Playables.PlayableOutputHandle::GetUserData_Injected");
			PlayableOutputHandle.SetUserData_InjectedDelegateField = IL2CPP.ResolveICall<PlayableOutputHandle.SetUserData_InjectedDelegate>("UnityEngine.Playables.PlayableOutputHandle::SetUserData_Injected");
			PlayableOutputHandle.GetSourcePlayable_InjectedDelegateField = IL2CPP.ResolveICall<PlayableOutputHandle.GetSourcePlayable_InjectedDelegate>("UnityEngine.Playables.PlayableOutputHandle::GetSourcePlayable_Injected");
			PlayableOutputHandle.SetSourcePlayable_InjectedDelegateField = IL2CPP.ResolveICall<PlayableOutputHandle.SetSourcePlayable_InjectedDelegate>("UnityEngine.Playables.PlayableOutputHandle::SetSourcePlayable_Injected");
			PlayableOutputHandle.GetSourceOutputPort_InjectedDelegateField = IL2CPP.ResolveICall<PlayableOutputHandle.GetSourceOutputPort_InjectedDelegate>("UnityEngine.Playables.PlayableOutputHandle::GetSourceOutputPort_Injected");
			PlayableOutputHandle.GetWeight_InjectedDelegateField = IL2CPP.ResolveICall<PlayableOutputHandle.GetWeight_InjectedDelegate>("UnityEngine.Playables.PlayableOutputHandle::GetWeight_Injected");
			PlayableOutputHandle.SetWeight_InjectedDelegateField = IL2CPP.ResolveICall<PlayableOutputHandle.SetWeight_InjectedDelegate>("UnityEngine.Playables.PlayableOutputHandle::SetWeight_Injected");
			PlayableOutputHandle.PushNotification_InjectedDelegateField = IL2CPP.ResolveICall<PlayableOutputHandle.PushNotification_InjectedDelegate>("UnityEngine.Playables.PlayableOutputHandle::PushNotification_Injected");
			PlayableOutputHandle.GetNotificationReceivers_InjectedDelegateField = IL2CPP.ResolveICall<PlayableOutputHandle.GetNotificationReceivers_InjectedDelegate>("UnityEngine.Playables.PlayableOutputHandle::GetNotificationReceivers_Injected");
			PlayableOutputHandle.AddNotificationReceiver_InjectedDelegateField = IL2CPP.ResolveICall<PlayableOutputHandle.AddNotificationReceiver_InjectedDelegate>("UnityEngine.Playables.PlayableOutputHandle::AddNotificationReceiver_Injected");
			PlayableOutputHandle.RemoveNotificationReceiver_InjectedDelegateField = IL2CPP.ResolveICall<PlayableOutputHandle.RemoveNotificationReceiver_InjectedDelegate>("UnityEngine.Playables.PlayableOutputHandle::RemoveNotificationReceiver_Injected");
		}

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x06001A42 RID: 6722 RVA: 0x0005E010 File Offset: 0x0005C210
		public unsafe static PlayableOutputHandle Null
		{
			[CallerCount(0)]
			[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82804, XrefRangeEnd = 82808, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.NativeMethodInfoPtr_get_Null_Public_Static_get_PlayableOutputHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A43 RID: 6723 RVA: 0x0005E040 File Offset: 0x0005C240
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A44 RID: 6724 RVA: 0x0005E070 File Offset: 0x0005C270
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82808, XrefRangeEnd = 82812, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(PlayableOutputHandle lhs, PlayableOutputHandle rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PlayableOutputHandle_PlayableOutputHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A45 RID: 6725 RVA: 0x0005E0BC File Offset: 0x0005C2BC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82812, XrefRangeEnd = 82819, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object p)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A46 RID: 6726 RVA: 0x0005E100 File Offset: 0x0005C300
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82819, XrefRangeEnd = 82823, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(PlayableOutputHandle other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PlayableOutputHandle_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x06001A47 RID: 6727 RVA: 0x0005E140 File Offset: 0x0005C340
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CompareVersion(PlayableOutputHandle lhs, PlayableOutputHandle rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableOutputHandle.NativeMethodInfoPtr_CompareVersion_Internal_Static_Boolean_PlayableOutputHandle_PlayableOutputHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x06001A48 RID: 6728 RVA: 0x0000E94D File Offset: 0x0000CB4D
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlayableOutputHandle>.NativeClassPtr, ref this));
		}

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x06001A49 RID: 6729 RVA: 0x0005E18C File Offset: 0x0005C38C
		// (set) Token: 0x06001A4A RID: 6730 RVA: 0x0000E95F File Offset: 0x0000CB5F
		public unsafe static PlayableOutputHandle m_Null
		{
			get
			{
				PlayableOutputHandle playableOutputHandle;
				IL2CPP.il2cpp_field_static_get_value(PlayableOutputHandle.NativeFieldInfoPtr_m_Null, (void*)(&playableOutputHandle));
				return playableOutputHandle;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayableOutputHandle.NativeFieldInfoPtr_m_Null, (void*)(&value));
			}
		}

		// Token: 0x06001A4B RID: 6731 RVA: 0x0005E1A8 File Offset: 0x0005C3A8
		public bool IsPlayableOutputOfType<T>()
		{
			return this.GetPlayableOutputType() == Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>());
		}

		// Token: 0x06001A4C RID: 6732 RVA: 0x0005E1CC File Offset: 0x0005C3CC
		public static bool operator !=(PlayableOutputHandle lhs, PlayableOutputHandle rhs)
		{
			return !PlayableOutputHandle.CompareVersion(lhs, rhs);
		}

		// Token: 0x06001A4D RID: 6733 RVA: 0x0000E96D File Offset: 0x0000CB6D
		public bool IsNull()
		{
			return PlayableOutputHandle.IsNull_Injected(ref this);
		}

		// Token: 0x06001A4E RID: 6734 RVA: 0x0000E975 File Offset: 0x0000CB75
		public bool IsValid()
		{
			return PlayableOutputHandle.IsValid_Injected(ref this);
		}

		// Token: 0x06001A4F RID: 6735 RVA: 0x0000E97D File Offset: 0x0000CB7D
		public Type GetPlayableOutputType()
		{
			return PlayableOutputHandle.GetPlayableOutputType_Injected(ref this);
		}

		// Token: 0x06001A50 RID: 6736 RVA: 0x0000E985 File Offset: 0x0000CB85
		public Object GetReferenceObject()
		{
			return PlayableOutputHandle.GetReferenceObject_Injected(ref this);
		}

		// Token: 0x06001A51 RID: 6737 RVA: 0x0000E98D File Offset: 0x0000CB8D
		public void SetReferenceObject(Object target)
		{
			PlayableOutputHandle.SetReferenceObject_Injected(ref this, target);
		}

		// Token: 0x06001A52 RID: 6738 RVA: 0x0000E996 File Offset: 0x0000CB96
		public Object GetUserData()
		{
			return PlayableOutputHandle.GetUserData_Injected(ref this);
		}

		// Token: 0x06001A53 RID: 6739 RVA: 0x0000E99E File Offset: 0x0000CB9E
		public void SetUserData(Object target)
		{
			PlayableOutputHandle.SetUserData_Injected(ref this, target);
		}

		// Token: 0x06001A54 RID: 6740 RVA: 0x0005E1E8 File Offset: 0x0005C3E8
		public PlayableHandle GetSourcePlayable()
		{
			PlayableHandle playableHandle;
			PlayableOutputHandle.GetSourcePlayable_Injected(ref this, out playableHandle);
			return playableHandle;
		}

		// Token: 0x06001A55 RID: 6741 RVA: 0x0000E9A7 File Offset: 0x0000CBA7
		public void SetSourcePlayable(PlayableHandle target, int port)
		{
			PlayableOutputHandle.SetSourcePlayable_Injected(ref this, ref target, port);
		}

		// Token: 0x06001A56 RID: 6742 RVA: 0x0000E9B2 File Offset: 0x0000CBB2
		public int GetSourceOutputPort()
		{
			return PlayableOutputHandle.GetSourceOutputPort_Injected(ref this);
		}

		// Token: 0x06001A57 RID: 6743 RVA: 0x0000E9BA File Offset: 0x0000CBBA
		public float GetWeight()
		{
			return PlayableOutputHandle.GetWeight_Injected(ref this);
		}

		// Token: 0x06001A58 RID: 6744 RVA: 0x0000E9C2 File Offset: 0x0000CBC2
		public void SetWeight(float weight)
		{
			PlayableOutputHandle.SetWeight_Injected(ref this, weight);
		}

		// Token: 0x06001A59 RID: 6745 RVA: 0x0000E9CB File Offset: 0x0000CBCB
		public void PushNotification(PlayableHandle origin, INotification notification, Object context)
		{
			PlayableOutputHandle.PushNotification_Injected(ref this, ref origin, notification, context);
		}

		// Token: 0x06001A5A RID: 6746 RVA: 0x0000E9D7 File Offset: 0x0000CBD7
		public Il2CppReferenceArray<INotificationReceiver> GetNotificationReceivers()
		{
			return PlayableOutputHandle.GetNotificationReceivers_Injected(ref this);
		}

		// Token: 0x06001A5B RID: 6747 RVA: 0x0000E9DF File Offset: 0x0000CBDF
		public void AddNotificationReceiver(INotificationReceiver receiver)
		{
			PlayableOutputHandle.AddNotificationReceiver_Injected(ref this, receiver);
		}

		// Token: 0x06001A5C RID: 6748 RVA: 0x0000E9E8 File Offset: 0x0000CBE8
		public void RemoveNotificationReceiver(INotificationReceiver receiver)
		{
			PlayableOutputHandle.RemoveNotificationReceiver_Injected(ref this, receiver);
		}

		// Token: 0x06001A5D RID: 6749 RVA: 0x0000E9F1 File Offset: 0x0000CBF1
		public static bool IsNull_Injected(ref PlayableOutputHandle _unity_self)
		{
			return PlayableOutputHandle.IsNull_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06001A5E RID: 6750 RVA: 0x0000E9FE File Offset: 0x0000CBFE
		public static bool IsValid_Injected(ref PlayableOutputHandle _unity_self)
		{
			return PlayableOutputHandle.IsValid_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06001A5F RID: 6751 RVA: 0x0005E200 File Offset: 0x0005C400
		public static Type GetPlayableOutputType_Injected(ref PlayableOutputHandle _unity_self)
		{
			IntPtr intPtr = PlayableOutputHandle.GetPlayableOutputType_InjectedDelegateField(ref _unity_self);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
		}

		// Token: 0x06001A60 RID: 6752 RVA: 0x0005E228 File Offset: 0x0005C428
		public static Object GetReferenceObject_Injected(ref PlayableOutputHandle _unity_self)
		{
			IntPtr intPtr = PlayableOutputHandle.GetReferenceObject_InjectedDelegateField(ref _unity_self);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
		}

		// Token: 0x06001A61 RID: 6753 RVA: 0x0000EA0B File Offset: 0x0000CC0B
		public static void SetReferenceObject_Injected(ref PlayableOutputHandle _unity_self, Object target)
		{
			PlayableOutputHandle.SetReferenceObject_InjectedDelegateField(ref _unity_self, IL2CPP.Il2CppObjectBaseToPtr(target));
		}

		// Token: 0x06001A62 RID: 6754 RVA: 0x0005E250 File Offset: 0x0005C450
		public static Object GetUserData_Injected(ref PlayableOutputHandle _unity_self)
		{
			IntPtr intPtr = PlayableOutputHandle.GetUserData_InjectedDelegateField(ref _unity_self);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
		}

		// Token: 0x06001A63 RID: 6755 RVA: 0x0000EA1E File Offset: 0x0000CC1E
		public static void SetUserData_Injected(ref PlayableOutputHandle _unity_self, Object target)
		{
			PlayableOutputHandle.SetUserData_InjectedDelegateField(ref _unity_self, IL2CPP.Il2CppObjectBaseToPtr(target));
		}

		// Token: 0x06001A64 RID: 6756 RVA: 0x0000EA31 File Offset: 0x0000CC31
		public static void GetSourcePlayable_Injected(ref PlayableOutputHandle _unity_self, out PlayableHandle ret)
		{
			PlayableOutputHandle.GetSourcePlayable_InjectedDelegateField(ref _unity_self, out ret);
		}

		// Token: 0x06001A65 RID: 6757 RVA: 0x0000EA3F File Offset: 0x0000CC3F
		public static void SetSourcePlayable_Injected(ref PlayableOutputHandle _unity_self, ref PlayableHandle target, int port)
		{
			PlayableOutputHandle.SetSourcePlayable_InjectedDelegateField(ref _unity_self, ref target, port);
		}

		// Token: 0x06001A66 RID: 6758 RVA: 0x0000EA4E File Offset: 0x0000CC4E
		public static int GetSourceOutputPort_Injected(ref PlayableOutputHandle _unity_self)
		{
			return PlayableOutputHandle.GetSourceOutputPort_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06001A67 RID: 6759 RVA: 0x0000EA5B File Offset: 0x0000CC5B
		public static float GetWeight_Injected(ref PlayableOutputHandle _unity_self)
		{
			return PlayableOutputHandle.GetWeight_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06001A68 RID: 6760 RVA: 0x0000EA68 File Offset: 0x0000CC68
		public static void SetWeight_Injected(ref PlayableOutputHandle _unity_self, float weight)
		{
			PlayableOutputHandle.SetWeight_InjectedDelegateField(ref _unity_self, weight);
		}

		// Token: 0x06001A69 RID: 6761 RVA: 0x0000EA76 File Offset: 0x0000CC76
		public static void PushNotification_Injected(ref PlayableOutputHandle _unity_self, ref PlayableHandle origin, INotification notification, Object context)
		{
			PlayableOutputHandle.PushNotification_InjectedDelegateField(ref _unity_self, ref origin, IL2CPP.Il2CppObjectBaseToPtr(notification), IL2CPP.Il2CppObjectBaseToPtr(context));
		}

		// Token: 0x06001A6A RID: 6762 RVA: 0x0005E278 File Offset: 0x0005C478
		public static Il2CppReferenceArray<INotificationReceiver> GetNotificationReceivers_Injected(ref PlayableOutputHandle _unity_self)
		{
			IntPtr intPtr = PlayableOutputHandle.GetNotificationReceivers_InjectedDelegateField(ref _unity_self);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<INotificationReceiver>>(intPtr2) : null;
		}

		// Token: 0x06001A6B RID: 6763 RVA: 0x0000EA90 File Offset: 0x0000CC90
		public static void AddNotificationReceiver_Injected(ref PlayableOutputHandle _unity_self, INotificationReceiver receiver)
		{
			PlayableOutputHandle.AddNotificationReceiver_InjectedDelegateField(ref _unity_self, IL2CPP.Il2CppObjectBaseToPtr(receiver));
		}

		// Token: 0x06001A6C RID: 6764 RVA: 0x0000EAA3 File Offset: 0x0000CCA3
		public static void RemoveNotificationReceiver_Injected(ref PlayableOutputHandle _unity_self, INotificationReceiver receiver)
		{
			PlayableOutputHandle.RemoveNotificationReceiver_InjectedDelegateField(ref _unity_self, IL2CPP.Il2CppObjectBaseToPtr(receiver));
		}

		// Token: 0x04001313 RID: 4883
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x04001314 RID: 4884
		private static readonly IntPtr NativeFieldInfoPtr_m_Version;

		// Token: 0x04001315 RID: 4885
		private static readonly IntPtr NativeFieldInfoPtr_m_Null;

		// Token: 0x04001316 RID: 4886
		private static readonly IntPtr NativeMethodInfoPtr_get_Null_Public_Static_get_PlayableOutputHandle_0;

		// Token: 0x04001317 RID: 4887
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x04001318 RID: 4888
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PlayableOutputHandle_PlayableOutputHandle_0;

		// Token: 0x04001319 RID: 4889
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x0400131A RID: 4890
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PlayableOutputHandle_0;

		// Token: 0x0400131B RID: 4891
		private static readonly IntPtr NativeMethodInfoPtr_CompareVersion_Internal_Static_Boolean_PlayableOutputHandle_PlayableOutputHandle_0;

		// Token: 0x0400131C RID: 4892
		[FieldOffset(0)]
		public IntPtr m_Handle;

		// Token: 0x0400131D RID: 4893
		[FieldOffset(8)]
		public uint m_Version;

		// Token: 0x0400131E RID: 4894
		private static readonly PlayableOutputHandle.IsNull_InjectedDelegate IsNull_InjectedDelegateField;

		// Token: 0x0400131F RID: 4895
		private static readonly PlayableOutputHandle.IsValid_InjectedDelegate IsValid_InjectedDelegateField;

		// Token: 0x04001320 RID: 4896
		private static readonly PlayableOutputHandle.GetPlayableOutputType_InjectedDelegate GetPlayableOutputType_InjectedDelegateField;

		// Token: 0x04001321 RID: 4897
		private static readonly PlayableOutputHandle.GetReferenceObject_InjectedDelegate GetReferenceObject_InjectedDelegateField;

		// Token: 0x04001322 RID: 4898
		private static readonly PlayableOutputHandle.SetReferenceObject_InjectedDelegate SetReferenceObject_InjectedDelegateField;

		// Token: 0x04001323 RID: 4899
		private static readonly PlayableOutputHandle.GetUserData_InjectedDelegate GetUserData_InjectedDelegateField;

		// Token: 0x04001324 RID: 4900
		private static readonly PlayableOutputHandle.SetUserData_InjectedDelegate SetUserData_InjectedDelegateField;

		// Token: 0x04001325 RID: 4901
		private static readonly PlayableOutputHandle.GetSourcePlayable_InjectedDelegate GetSourcePlayable_InjectedDelegateField;

		// Token: 0x04001326 RID: 4902
		private static readonly PlayableOutputHandle.SetSourcePlayable_InjectedDelegate SetSourcePlayable_InjectedDelegateField;

		// Token: 0x04001327 RID: 4903
		private static readonly PlayableOutputHandle.GetSourceOutputPort_InjectedDelegate GetSourceOutputPort_InjectedDelegateField;

		// Token: 0x04001328 RID: 4904
		private static readonly PlayableOutputHandle.GetWeight_InjectedDelegate GetWeight_InjectedDelegateField;

		// Token: 0x04001329 RID: 4905
		private static readonly PlayableOutputHandle.SetWeight_InjectedDelegate SetWeight_InjectedDelegateField;

		// Token: 0x0400132A RID: 4906
		private static readonly PlayableOutputHandle.PushNotification_InjectedDelegate PushNotification_InjectedDelegateField;

		// Token: 0x0400132B RID: 4907
		private static readonly PlayableOutputHandle.GetNotificationReceivers_InjectedDelegate GetNotificationReceivers_InjectedDelegateField;

		// Token: 0x0400132C RID: 4908
		private static readonly PlayableOutputHandle.AddNotificationReceiver_InjectedDelegate AddNotificationReceiver_InjectedDelegateField;

		// Token: 0x0400132D RID: 4909
		private static readonly PlayableOutputHandle.RemoveNotificationReceiver_InjectedDelegate RemoveNotificationReceiver_InjectedDelegateField;

		// Token: 0x020009F3 RID: 2547
		// (Invoke) Token: 0x06003205 RID: 12805
		private delegate bool IsNull_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x020009F4 RID: 2548
		// (Invoke) Token: 0x06003207 RID: 12807
		private delegate bool IsValid_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x020009F5 RID: 2549
		// (Invoke) Token: 0x06003209 RID: 12809
		private delegate IntPtr GetPlayableOutputType_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x020009F6 RID: 2550
		// (Invoke) Token: 0x0600320B RID: 12811
		private delegate IntPtr GetReferenceObject_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x020009F7 RID: 2551
		// (Invoke) Token: 0x0600320D RID: 12813
		private delegate void SetReferenceObject_InjectedDelegate(IntPtr _unity_self, IntPtr target);

		// Token: 0x020009F8 RID: 2552
		// (Invoke) Token: 0x0600320F RID: 12815
		private delegate IntPtr GetUserData_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x020009F9 RID: 2553
		// (Invoke) Token: 0x06003211 RID: 12817
		private delegate void SetUserData_InjectedDelegate(IntPtr _unity_self, IntPtr target);

		// Token: 0x020009FA RID: 2554
		// (Invoke) Token: 0x06003213 RID: 12819
		private delegate void GetSourcePlayable_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

		// Token: 0x020009FB RID: 2555
		// (Invoke) Token: 0x06003215 RID: 12821
		private delegate void SetSourcePlayable_InjectedDelegate(IntPtr _unity_self, IntPtr target, int port);

		// Token: 0x020009FC RID: 2556
		// (Invoke) Token: 0x06003217 RID: 12823
		private delegate int GetSourceOutputPort_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x020009FD RID: 2557
		// (Invoke) Token: 0x06003219 RID: 12825
		private delegate float GetWeight_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x020009FE RID: 2558
		// (Invoke) Token: 0x0600321B RID: 12827
		private delegate void SetWeight_InjectedDelegate(IntPtr _unity_self, float weight);

		// Token: 0x020009FF RID: 2559
		// (Invoke) Token: 0x0600321D RID: 12829
		private delegate void PushNotification_InjectedDelegate(IntPtr _unity_self, IntPtr origin, IntPtr notification, IntPtr context);

		// Token: 0x02000A00 RID: 2560
		// (Invoke) Token: 0x0600321F RID: 12831
		private delegate IntPtr GetNotificationReceivers_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x02000A01 RID: 2561
		// (Invoke) Token: 0x06003221 RID: 12833
		private delegate void AddNotificationReceiver_InjectedDelegate(IntPtr _unity_self, IntPtr receiver);

		// Token: 0x02000A02 RID: 2562
		// (Invoke) Token: 0x06003223 RID: 12835
		private delegate void RemoveNotificationReceiver_InjectedDelegate(IntPtr _unity_self, IntPtr receiver);
	}
}
