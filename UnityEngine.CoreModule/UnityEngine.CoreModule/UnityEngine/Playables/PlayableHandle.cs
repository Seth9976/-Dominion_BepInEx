using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Reflection;

namespace UnityEngine.Playables
{
	// Token: 0x02000151 RID: 337
	[StructLayout(2)]
	public struct PlayableHandle
	{
		// Token: 0x060019CD RID: 6605 RVA: 0x0005D450 File Offset: 0x0005B650
		// Note: this type is marked as 'beforefieldinit'.
		static PlayableHandle()
		{
			Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Playables", "PlayableHandle");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr);
			PlayableHandle.NativeFieldInfoPtr_m_Handle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, "m_Handle");
			PlayableHandle.NativeFieldInfoPtr_m_Version = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, "m_Version");
			PlayableHandle.NativeFieldInfoPtr_m_Null = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, "m_Null");
			PlayableHandle.NativeMethodInfoPtr_IsPlayableOfType_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100665208);
			PlayableHandle.NativeMethodInfoPtr_get_Null_Public_Static_get_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100665209);
			PlayableHandle.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PlayableHandle_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100665210);
			PlayableHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100665211);
			PlayableHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100665212);
			PlayableHandle.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100665213);
			PlayableHandle.NativeMethodInfoPtr_CompareVersion_Internal_Static_Boolean_PlayableHandle_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100665214);
			PlayableHandle.NativeMethodInfoPtr_IsValid_Internal_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100665215);
			PlayableHandle.NativeMethodInfoPtr_GetPlayableType_Internal_Type_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100665216);
			PlayableHandle.NativeMethodInfoPtr_IsValid_Injected_Private_Static_Boolean_byref_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100665218);
			PlayableHandle.NativeMethodInfoPtr_GetPlayableType_Injected_Private_Static_Type_byref_PlayableHandle_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, 100665219);
			PlayableHandle.IsNull_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.IsNull_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::IsNull_Injected");
			PlayableHandle.GetJobType_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.GetJobType_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::GetJobType_Injected");
			PlayableHandle.SetScriptInstance_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.SetScriptInstance_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::SetScriptInstance_Injected");
			PlayableHandle.CanChangeInputs_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.CanChangeInputs_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::CanChangeInputs_Injected");
			PlayableHandle.CanSetWeights_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.CanSetWeights_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::CanSetWeights_Injected");
			PlayableHandle.CanDestroy_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.CanDestroy_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::CanDestroy_Injected");
			PlayableHandle.GetPlayState_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.GetPlayState_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::GetPlayState_Injected");
			PlayableHandle.Play_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.Play_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::Play_Injected");
			PlayableHandle.Pause_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.Pause_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::Pause_Injected");
			PlayableHandle.GetSpeed_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.GetSpeed_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::GetSpeed_Injected");
			PlayableHandle.SetSpeed_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.SetSpeed_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::SetSpeed_Injected");
			PlayableHandle.GetTime_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.GetTime_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::GetTime_Injected");
			PlayableHandle.SetTime_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.SetTime_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::SetTime_Injected");
			PlayableHandle.IsDone_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.IsDone_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::IsDone_Injected");
			PlayableHandle.SetDone_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.SetDone_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::SetDone_Injected");
			PlayableHandle.GetDuration_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.GetDuration_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::GetDuration_Injected");
			PlayableHandle.SetDuration_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.SetDuration_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::SetDuration_Injected");
			PlayableHandle.GetPropagateSetTime_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.GetPropagateSetTime_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::GetPropagateSetTime_Injected");
			PlayableHandle.SetPropagateSetTime_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.SetPropagateSetTime_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::SetPropagateSetTime_Injected");
			PlayableHandle.GetGraph_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.GetGraph_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::GetGraph_Injected");
			PlayableHandle.GetInputCount_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.GetInputCount_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::GetInputCount_Injected");
			PlayableHandle.SetInputCount_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.SetInputCount_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::SetInputCount_Injected");
			PlayableHandle.GetOutputCount_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.GetOutputCount_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::GetOutputCount_Injected");
			PlayableHandle.SetOutputCount_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.SetOutputCount_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::SetOutputCount_Injected");
			PlayableHandle.SetInputWeight_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.SetInputWeight_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::SetInputWeight_Injected");
			PlayableHandle.SetDelay_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.SetDelay_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::SetDelay_Injected");
			PlayableHandle.GetDelay_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.GetDelay_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::GetDelay_Injected");
			PlayableHandle.IsDelayed_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.IsDelayed_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::IsDelayed_Injected");
			PlayableHandle.GetPreviousTime_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.GetPreviousTime_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::GetPreviousTime_Injected");
			PlayableHandle.SetLeadTime_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.SetLeadTime_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::SetLeadTime_Injected");
			PlayableHandle.GetLeadTime_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.GetLeadTime_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::GetLeadTime_Injected");
			PlayableHandle.GetTraversalMode_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.GetTraversalMode_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::GetTraversalMode_Injected");
			PlayableHandle.SetTraversalMode_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.SetTraversalMode_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::SetTraversalMode_Injected");
			PlayableHandle.GetJobData_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.GetJobData_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::GetJobData_Injected");
			PlayableHandle.GetTimeWrapMode_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.GetTimeWrapMode_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::GetTimeWrapMode_Injected");
			PlayableHandle.SetTimeWrapMode_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.SetTimeWrapMode_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::SetTimeWrapMode_Injected");
			PlayableHandle.GetScriptInstance_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.GetScriptInstance_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::GetScriptInstance_Injected");
			PlayableHandle.GetInputHandle_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.GetInputHandle_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::GetInputHandle_Injected");
			PlayableHandle.GetOutputHandle_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.GetOutputHandle_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::GetOutputHandle_Injected");
			PlayableHandle.SetInputWeightFromIndex_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.SetInputWeightFromIndex_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::SetInputWeightFromIndex_Injected");
			PlayableHandle.GetInputWeightFromIndex_InjectedDelegateField = IL2CPP.ResolveICall<PlayableHandle.GetInputWeightFromIndex_InjectedDelegate>("UnityEngine.Playables.PlayableHandle::GetInputWeightFromIndex_Injected");
		}

		// Token: 0x060019CE RID: 6606 RVA: 0x0005D800 File Offset: 0x0005BA00
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 82736, RefRangeEnd = 82737, XrefRangeStart = 82731, XrefRangeEnd = 82736, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsPlayableOfType<T>()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.MethodInfoStoreGeneric_IsPlayableOfType_Internal_Boolean_0<T>.Pointer, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x060019CF RID: 6607 RVA: 0x0005D830 File Offset: 0x0005BA30
		public unsafe static PlayableHandle Null
		{
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 82741, RefRangeEnd = 82742, XrefRangeStart = 82737, XrefRangeEnd = 82741, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_get_Null_Public_Static_get_PlayableHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019D0 RID: 6608 RVA: 0x0005D860 File Offset: 0x0005BA60
		[CallerCount(10)]
		[CachedScanResults(RefRangeStart = 82746, RefRangeEnd = 82756, XrefRangeStart = 82742, XrefRangeEnd = 82746, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool operator ==(PlayableHandle x, PlayableHandle y)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref x;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref y;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PlayableHandle_PlayableHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019D1 RID: 6609 RVA: 0x0005D8AC File Offset: 0x0005BAAC
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82756, XrefRangeEnd = 82763, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override bool Equals(Object p)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(p);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019D2 RID: 6610 RVA: 0x0005D8F0 File Offset: 0x0005BAF0
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82763, XrefRangeEnd = 82767, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool Equals(PlayableHandle other)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref other;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PlayableHandle_0, ref this, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019D3 RID: 6611 RVA: 0x0005D930 File Offset: 0x0005BB30
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82767, XrefRangeEnd = 82769, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override int GetHashCode()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019D4 RID: 6612 RVA: 0x0005D960 File Offset: 0x0005BB60
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82769, XrefRangeEnd = 82770, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool CompareVersion(PlayableHandle lhs, PlayableHandle rhs)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref lhs;
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref rhs;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_CompareVersion_Internal_Static_Boolean_PlayableHandle_PlayableHandle_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019D5 RID: 6613 RVA: 0x0005D9AC File Offset: 0x0005BBAC
		[CallerCount(9)]
		[CachedScanResults(RefRangeStart = 82777, RefRangeEnd = 82786, XrefRangeStart = 82770, XrefRangeEnd = 82777, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe bool IsValid()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_IsValid_Internal_Boolean_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060019D6 RID: 6614 RVA: 0x0005D9DC File Offset: 0x0005BBDC
		[CallerCount(1)]
		[CachedScanResults(RefRangeStart = 82791, RefRangeEnd = 82792, XrefRangeStart = 82786, XrefRangeEnd = 82791, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe Type GetPlayableType()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_GetPlayableType_Internal_Type_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			IntPtr intPtr3 = intPtr;
			return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
		}

		// Token: 0x060019D7 RID: 6615 RVA: 0x0005DA10 File Offset: 0x0005BC10
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82792, XrefRangeEnd = 82794, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static bool IsValid_Injected(ref PlayableHandle _unity_self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &_unity_self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_IsValid_Injected_Private_Static_Boolean_byref_PlayableHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x060019D8 RID: 6616 RVA: 0x0005DA50 File Offset: 0x0005BC50
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 82794, XrefRangeEnd = 82796, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static Type GetPlayableType_Injected(ref PlayableHandle _unity_self)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = &_unity_self;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PlayableHandle.NativeMethodInfoPtr_GetPlayableType_Injected_Private_Static_Type_byref_PlayableHandle_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<Type>(intPtr3) : null;
			}
		}

		// Token: 0x060019D9 RID: 6617 RVA: 0x0000E5A8 File Offset: 0x0000C7A8
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr, ref this));
		}

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x060019DA RID: 6618 RVA: 0x0005DA90 File Offset: 0x0005BC90
		// (set) Token: 0x060019DB RID: 6619 RVA: 0x0000E5BA File Offset: 0x0000C7BA
		public unsafe static PlayableHandle m_Null
		{
			get
			{
				PlayableHandle playableHandle;
				IL2CPP.il2cpp_field_static_get_value(PlayableHandle.NativeFieldInfoPtr_m_Null, (void*)(&playableHandle));
				return playableHandle;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PlayableHandle.NativeFieldInfoPtr_m_Null, (void*)(&value));
			}
		}

		// Token: 0x060019DC RID: 6620 RVA: 0x0005DAAC File Offset: 0x0005BCAC
		public T GetObject<T>() where T : class
		{
			bool flag = !this.IsValid();
			T t;
			if (flag)
			{
				t = default(T);
			}
			else
			{
				Object scriptInstance = this.GetScriptInstance();
				bool flag2 = scriptInstance == null;
				if (flag2)
				{
					t = default(T);
				}
				else
				{
					t = scriptInstance.Cast<T>();
				}
			}
			return t;
		}

		// Token: 0x060019DD RID: 6621 RVA: 0x0005DAFC File Offset: 0x0005BCFC
		public Playable GetInput(int inputPort)
		{
			return new Playable(this.GetInputHandle(inputPort));
		}

		// Token: 0x060019DE RID: 6622 RVA: 0x0005DB1C File Offset: 0x0005BD1C
		public Playable GetOutput(int outputPort)
		{
			return new Playable(this.GetOutputHandle(outputPort));
		}

		// Token: 0x060019DF RID: 6623 RVA: 0x0005DB3C File Offset: 0x0005BD3C
		public bool SetInputWeight(int inputIndex, float weight)
		{
			bool flag = this.CheckInputBounds(inputIndex);
			bool flag2;
			if (flag)
			{
				this.SetInputWeightFromIndex(inputIndex, weight);
				flag2 = true;
			}
			else
			{
				flag2 = false;
			}
			return flag2;
		}

		// Token: 0x060019E0 RID: 6624 RVA: 0x0005DB68 File Offset: 0x0005BD68
		public float GetInputWeight(int inputIndex)
		{
			bool flag = this.CheckInputBounds(inputIndex);
			float num;
			if (flag)
			{
				num = this.GetInputWeightFromIndex(inputIndex);
			}
			else
			{
				num = 0f;
			}
			return num;
		}

		// Token: 0x060019E1 RID: 6625 RVA: 0x0005DB98 File Offset: 0x0005BD98
		public void Destroy()
		{
			this.GetGraph().DestroyPlayable<Playable>(new Playable(this));
		}

		// Token: 0x060019E2 RID: 6626 RVA: 0x0005DBC0 File Offset: 0x0005BDC0
		public static bool operator !=(PlayableHandle x, PlayableHandle y)
		{
			return !PlayableHandle.CompareVersion(x, y);
		}

		// Token: 0x060019E3 RID: 6627 RVA: 0x0005DBDC File Offset: 0x0005BDDC
		public bool CheckInputBounds(int inputIndex)
		{
			return this.CheckInputBounds(inputIndex, false);
		}

		// Token: 0x060019E4 RID: 6628 RVA: 0x0000E5C8 File Offset: 0x0000C7C8
		public bool CheckInputBounds(int inputIndex, bool acceptAny)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x060019E5 RID: 6629 RVA: 0x0000E5D5 File Offset: 0x0000C7D5
		public bool IsNull()
		{
			return PlayableHandle.IsNull_Injected(ref this);
		}

		// Token: 0x060019E6 RID: 6630 RVA: 0x0000E5DD File Offset: 0x0000C7DD
		public Type GetJobType()
		{
			return PlayableHandle.GetJobType_Injected(ref this);
		}

		// Token: 0x060019E7 RID: 6631 RVA: 0x0000E5E5 File Offset: 0x0000C7E5
		public void SetScriptInstance(Object scriptInstance)
		{
			PlayableHandle.SetScriptInstance_Injected(ref this, scriptInstance);
		}

		// Token: 0x060019E8 RID: 6632 RVA: 0x0000E5EE File Offset: 0x0000C7EE
		public bool CanChangeInputs()
		{
			return PlayableHandle.CanChangeInputs_Injected(ref this);
		}

		// Token: 0x060019E9 RID: 6633 RVA: 0x0000E5F6 File Offset: 0x0000C7F6
		public bool CanSetWeights()
		{
			return PlayableHandle.CanSetWeights_Injected(ref this);
		}

		// Token: 0x060019EA RID: 6634 RVA: 0x0000E5FE File Offset: 0x0000C7FE
		public bool CanDestroy()
		{
			return PlayableHandle.CanDestroy_Injected(ref this);
		}

		// Token: 0x060019EB RID: 6635 RVA: 0x0000E606 File Offset: 0x0000C806
		public PlayState GetPlayState()
		{
			return PlayableHandle.GetPlayState_Injected(ref this);
		}

		// Token: 0x060019EC RID: 6636 RVA: 0x0000E60E File Offset: 0x0000C80E
		public void Play()
		{
			PlayableHandle.Play_Injected(ref this);
		}

		// Token: 0x060019ED RID: 6637 RVA: 0x0000E616 File Offset: 0x0000C816
		public void Pause()
		{
			PlayableHandle.Pause_Injected(ref this);
		}

		// Token: 0x060019EE RID: 6638 RVA: 0x0000E61E File Offset: 0x0000C81E
		public double GetSpeed()
		{
			return PlayableHandle.GetSpeed_Injected(ref this);
		}

		// Token: 0x060019EF RID: 6639 RVA: 0x0000E626 File Offset: 0x0000C826
		public void SetSpeed(double value)
		{
			PlayableHandle.SetSpeed_Injected(ref this, value);
		}

		// Token: 0x060019F0 RID: 6640 RVA: 0x0000E62F File Offset: 0x0000C82F
		public double GetTime()
		{
			return PlayableHandle.GetTime_Injected(ref this);
		}

		// Token: 0x060019F1 RID: 6641 RVA: 0x0000E637 File Offset: 0x0000C837
		public void SetTime(double value)
		{
			PlayableHandle.SetTime_Injected(ref this, value);
		}

		// Token: 0x060019F2 RID: 6642 RVA: 0x0000E640 File Offset: 0x0000C840
		public bool IsDone()
		{
			return PlayableHandle.IsDone_Injected(ref this);
		}

		// Token: 0x060019F3 RID: 6643 RVA: 0x0000E648 File Offset: 0x0000C848
		public void SetDone(bool value)
		{
			PlayableHandle.SetDone_Injected(ref this, value);
		}

		// Token: 0x060019F4 RID: 6644 RVA: 0x0000E651 File Offset: 0x0000C851
		public double GetDuration()
		{
			return PlayableHandle.GetDuration_Injected(ref this);
		}

		// Token: 0x060019F5 RID: 6645 RVA: 0x0000E659 File Offset: 0x0000C859
		public void SetDuration(double value)
		{
			PlayableHandle.SetDuration_Injected(ref this, value);
		}

		// Token: 0x060019F6 RID: 6646 RVA: 0x0000E662 File Offset: 0x0000C862
		public bool GetPropagateSetTime()
		{
			return PlayableHandle.GetPropagateSetTime_Injected(ref this);
		}

		// Token: 0x060019F7 RID: 6647 RVA: 0x0000E66A File Offset: 0x0000C86A
		public void SetPropagateSetTime(bool value)
		{
			PlayableHandle.SetPropagateSetTime_Injected(ref this, value);
		}

		// Token: 0x060019F8 RID: 6648 RVA: 0x0005DBF8 File Offset: 0x0005BDF8
		public PlayableGraph GetGraph()
		{
			PlayableGraph playableGraph;
			PlayableHandle.GetGraph_Injected(ref this, out playableGraph);
			return playableGraph;
		}

		// Token: 0x060019F9 RID: 6649 RVA: 0x0000E673 File Offset: 0x0000C873
		public int GetInputCount()
		{
			return PlayableHandle.GetInputCount_Injected(ref this);
		}

		// Token: 0x060019FA RID: 6650 RVA: 0x0000E67B File Offset: 0x0000C87B
		public void SetInputCount(int value)
		{
			PlayableHandle.SetInputCount_Injected(ref this, value);
		}

		// Token: 0x060019FB RID: 6651 RVA: 0x0000E684 File Offset: 0x0000C884
		public int GetOutputCount()
		{
			return PlayableHandle.GetOutputCount_Injected(ref this);
		}

		// Token: 0x060019FC RID: 6652 RVA: 0x0000E68C File Offset: 0x0000C88C
		public void SetOutputCount(int value)
		{
			PlayableHandle.SetOutputCount_Injected(ref this, value);
		}

		// Token: 0x060019FD RID: 6653 RVA: 0x0000E695 File Offset: 0x0000C895
		public void SetInputWeight(PlayableHandle input, float weight)
		{
			PlayableHandle.SetInputWeight_Injected(ref this, ref input, weight);
		}

		// Token: 0x060019FE RID: 6654 RVA: 0x0000E6A0 File Offset: 0x0000C8A0
		public void SetDelay(double delay)
		{
			PlayableHandle.SetDelay_Injected(ref this, delay);
		}

		// Token: 0x060019FF RID: 6655 RVA: 0x0000E6A9 File Offset: 0x0000C8A9
		public double GetDelay()
		{
			return PlayableHandle.GetDelay_Injected(ref this);
		}

		// Token: 0x06001A00 RID: 6656 RVA: 0x0000E6B1 File Offset: 0x0000C8B1
		public bool IsDelayed()
		{
			return PlayableHandle.IsDelayed_Injected(ref this);
		}

		// Token: 0x06001A01 RID: 6657 RVA: 0x0000E6B9 File Offset: 0x0000C8B9
		public double GetPreviousTime()
		{
			return PlayableHandle.GetPreviousTime_Injected(ref this);
		}

		// Token: 0x06001A02 RID: 6658 RVA: 0x0000E6C1 File Offset: 0x0000C8C1
		public void SetLeadTime(float value)
		{
			PlayableHandle.SetLeadTime_Injected(ref this, value);
		}

		// Token: 0x06001A03 RID: 6659 RVA: 0x0000E6CA File Offset: 0x0000C8CA
		public float GetLeadTime()
		{
			return PlayableHandle.GetLeadTime_Injected(ref this);
		}

		// Token: 0x06001A04 RID: 6660 RVA: 0x0000E6D2 File Offset: 0x0000C8D2
		public PlayableTraversalMode GetTraversalMode()
		{
			return PlayableHandle.GetTraversalMode_Injected(ref this);
		}

		// Token: 0x06001A05 RID: 6661 RVA: 0x0000E6DA File Offset: 0x0000C8DA
		public void SetTraversalMode(PlayableTraversalMode mode)
		{
			PlayableHandle.SetTraversalMode_Injected(ref this, mode);
		}

		// Token: 0x06001A06 RID: 6662 RVA: 0x0000E6E3 File Offset: 0x0000C8E3
		public IntPtr GetJobData()
		{
			return PlayableHandle.GetJobData_Injected(ref this);
		}

		// Token: 0x06001A07 RID: 6663 RVA: 0x0000E6EB File Offset: 0x0000C8EB
		public DirectorWrapMode GetTimeWrapMode()
		{
			return PlayableHandle.GetTimeWrapMode_Injected(ref this);
		}

		// Token: 0x06001A08 RID: 6664 RVA: 0x0000E6F3 File Offset: 0x0000C8F3
		public void SetTimeWrapMode(DirectorWrapMode mode)
		{
			PlayableHandle.SetTimeWrapMode_Injected(ref this, mode);
		}

		// Token: 0x06001A09 RID: 6665 RVA: 0x0000E6FC File Offset: 0x0000C8FC
		public Object GetScriptInstance()
		{
			return PlayableHandle.GetScriptInstance_Injected(ref this);
		}

		// Token: 0x06001A0A RID: 6666 RVA: 0x0005DC10 File Offset: 0x0005BE10
		public PlayableHandle GetInputHandle(int index)
		{
			PlayableHandle playableHandle;
			PlayableHandle.GetInputHandle_Injected(ref this, index, out playableHandle);
			return playableHandle;
		}

		// Token: 0x06001A0B RID: 6667 RVA: 0x0005DC28 File Offset: 0x0005BE28
		public PlayableHandle GetOutputHandle(int index)
		{
			PlayableHandle playableHandle;
			PlayableHandle.GetOutputHandle_Injected(ref this, index, out playableHandle);
			return playableHandle;
		}

		// Token: 0x06001A0C RID: 6668 RVA: 0x0000E704 File Offset: 0x0000C904
		public void SetInputWeightFromIndex(int index, float weight)
		{
			PlayableHandle.SetInputWeightFromIndex_Injected(ref this, index, weight);
		}

		// Token: 0x06001A0D RID: 6669 RVA: 0x0000E70E File Offset: 0x0000C90E
		public float GetInputWeightFromIndex(int index)
		{
			return PlayableHandle.GetInputWeightFromIndex_Injected(ref this, index);
		}

		// Token: 0x06001A0E RID: 6670 RVA: 0x0000E717 File Offset: 0x0000C917
		public static bool IsNull_Injected(ref PlayableHandle _unity_self)
		{
			return PlayableHandle.IsNull_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06001A0F RID: 6671 RVA: 0x0005DC40 File Offset: 0x0005BE40
		public static Type GetJobType_Injected(ref PlayableHandle _unity_self)
		{
			IntPtr intPtr = PlayableHandle.GetJobType_InjectedDelegateField(ref _unity_self);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Type>(intPtr2) : null;
		}

		// Token: 0x06001A10 RID: 6672 RVA: 0x0000E724 File Offset: 0x0000C924
		public static void SetScriptInstance_Injected(ref PlayableHandle _unity_self, Object scriptInstance)
		{
			PlayableHandle.SetScriptInstance_InjectedDelegateField(ref _unity_self, IL2CPP.Il2CppObjectBaseToPtr(scriptInstance));
		}

		// Token: 0x06001A11 RID: 6673 RVA: 0x0000E737 File Offset: 0x0000C937
		public static bool CanChangeInputs_Injected(ref PlayableHandle _unity_self)
		{
			return PlayableHandle.CanChangeInputs_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06001A12 RID: 6674 RVA: 0x0000E744 File Offset: 0x0000C944
		public static bool CanSetWeights_Injected(ref PlayableHandle _unity_self)
		{
			return PlayableHandle.CanSetWeights_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06001A13 RID: 6675 RVA: 0x0000E751 File Offset: 0x0000C951
		public static bool CanDestroy_Injected(ref PlayableHandle _unity_self)
		{
			return PlayableHandle.CanDestroy_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06001A14 RID: 6676 RVA: 0x0000E75E File Offset: 0x0000C95E
		public static PlayState GetPlayState_Injected(ref PlayableHandle _unity_self)
		{
			return PlayableHandle.GetPlayState_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06001A15 RID: 6677 RVA: 0x0000E76B File Offset: 0x0000C96B
		public static void Play_Injected(ref PlayableHandle _unity_self)
		{
			PlayableHandle.Play_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06001A16 RID: 6678 RVA: 0x0000E778 File Offset: 0x0000C978
		public static void Pause_Injected(ref PlayableHandle _unity_self)
		{
			PlayableHandle.Pause_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06001A17 RID: 6679 RVA: 0x0000E785 File Offset: 0x0000C985
		public static double GetSpeed_Injected(ref PlayableHandle _unity_self)
		{
			return PlayableHandle.GetSpeed_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06001A18 RID: 6680 RVA: 0x0000E792 File Offset: 0x0000C992
		public static void SetSpeed_Injected(ref PlayableHandle _unity_self, double value)
		{
			PlayableHandle.SetSpeed_InjectedDelegateField(ref _unity_self, value);
		}

		// Token: 0x06001A19 RID: 6681 RVA: 0x0000E7A0 File Offset: 0x0000C9A0
		public static double GetTime_Injected(ref PlayableHandle _unity_self)
		{
			return PlayableHandle.GetTime_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06001A1A RID: 6682 RVA: 0x0000E7AD File Offset: 0x0000C9AD
		public static void SetTime_Injected(ref PlayableHandle _unity_self, double value)
		{
			PlayableHandle.SetTime_InjectedDelegateField(ref _unity_self, value);
		}

		// Token: 0x06001A1B RID: 6683 RVA: 0x0000E7BB File Offset: 0x0000C9BB
		public static bool IsDone_Injected(ref PlayableHandle _unity_self)
		{
			return PlayableHandle.IsDone_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06001A1C RID: 6684 RVA: 0x0000E7C8 File Offset: 0x0000C9C8
		public static void SetDone_Injected(ref PlayableHandle _unity_self, bool value)
		{
			PlayableHandle.SetDone_InjectedDelegateField(ref _unity_self, value);
		}

		// Token: 0x06001A1D RID: 6685 RVA: 0x0000E7D6 File Offset: 0x0000C9D6
		public static double GetDuration_Injected(ref PlayableHandle _unity_self)
		{
			return PlayableHandle.GetDuration_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06001A1E RID: 6686 RVA: 0x0000E7E3 File Offset: 0x0000C9E3
		public static void SetDuration_Injected(ref PlayableHandle _unity_self, double value)
		{
			PlayableHandle.SetDuration_InjectedDelegateField(ref _unity_self, value);
		}

		// Token: 0x06001A1F RID: 6687 RVA: 0x0000E7F1 File Offset: 0x0000C9F1
		public static bool GetPropagateSetTime_Injected(ref PlayableHandle _unity_self)
		{
			return PlayableHandle.GetPropagateSetTime_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06001A20 RID: 6688 RVA: 0x0000E7FE File Offset: 0x0000C9FE
		public static void SetPropagateSetTime_Injected(ref PlayableHandle _unity_self, bool value)
		{
			PlayableHandle.SetPropagateSetTime_InjectedDelegateField(ref _unity_self, value);
		}

		// Token: 0x06001A21 RID: 6689 RVA: 0x0000E80C File Offset: 0x0000CA0C
		public static void GetGraph_Injected(ref PlayableHandle _unity_self, out PlayableGraph ret)
		{
			PlayableHandle.GetGraph_InjectedDelegateField(ref _unity_self, out ret);
		}

		// Token: 0x06001A22 RID: 6690 RVA: 0x0000E81A File Offset: 0x0000CA1A
		public static int GetInputCount_Injected(ref PlayableHandle _unity_self)
		{
			return PlayableHandle.GetInputCount_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06001A23 RID: 6691 RVA: 0x0000E827 File Offset: 0x0000CA27
		public static void SetInputCount_Injected(ref PlayableHandle _unity_self, int value)
		{
			PlayableHandle.SetInputCount_InjectedDelegateField(ref _unity_self, value);
		}

		// Token: 0x06001A24 RID: 6692 RVA: 0x0000E835 File Offset: 0x0000CA35
		public static int GetOutputCount_Injected(ref PlayableHandle _unity_self)
		{
			return PlayableHandle.GetOutputCount_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06001A25 RID: 6693 RVA: 0x0000E842 File Offset: 0x0000CA42
		public static void SetOutputCount_Injected(ref PlayableHandle _unity_self, int value)
		{
			PlayableHandle.SetOutputCount_InjectedDelegateField(ref _unity_self, value);
		}

		// Token: 0x06001A26 RID: 6694 RVA: 0x0000E850 File Offset: 0x0000CA50
		public static void SetInputWeight_Injected(ref PlayableHandle _unity_self, ref PlayableHandle input, float weight)
		{
			PlayableHandle.SetInputWeight_InjectedDelegateField(ref _unity_self, ref input, weight);
		}

		// Token: 0x06001A27 RID: 6695 RVA: 0x0000E85F File Offset: 0x0000CA5F
		public static void SetDelay_Injected(ref PlayableHandle _unity_self, double delay)
		{
			PlayableHandle.SetDelay_InjectedDelegateField(ref _unity_self, delay);
		}

		// Token: 0x06001A28 RID: 6696 RVA: 0x0000E86D File Offset: 0x0000CA6D
		public static double GetDelay_Injected(ref PlayableHandle _unity_self)
		{
			return PlayableHandle.GetDelay_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06001A29 RID: 6697 RVA: 0x0000E87A File Offset: 0x0000CA7A
		public static bool IsDelayed_Injected(ref PlayableHandle _unity_self)
		{
			return PlayableHandle.IsDelayed_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06001A2A RID: 6698 RVA: 0x0000E887 File Offset: 0x0000CA87
		public static double GetPreviousTime_Injected(ref PlayableHandle _unity_self)
		{
			return PlayableHandle.GetPreviousTime_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06001A2B RID: 6699 RVA: 0x0000E894 File Offset: 0x0000CA94
		public static void SetLeadTime_Injected(ref PlayableHandle _unity_self, float value)
		{
			PlayableHandle.SetLeadTime_InjectedDelegateField(ref _unity_self, value);
		}

		// Token: 0x06001A2C RID: 6700 RVA: 0x0000E8A2 File Offset: 0x0000CAA2
		public static float GetLeadTime_Injected(ref PlayableHandle _unity_self)
		{
			return PlayableHandle.GetLeadTime_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06001A2D RID: 6701 RVA: 0x0000E8AF File Offset: 0x0000CAAF
		public static PlayableTraversalMode GetTraversalMode_Injected(ref PlayableHandle _unity_self)
		{
			return PlayableHandle.GetTraversalMode_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06001A2E RID: 6702 RVA: 0x0000E8BC File Offset: 0x0000CABC
		public static void SetTraversalMode_Injected(ref PlayableHandle _unity_self, PlayableTraversalMode mode)
		{
			PlayableHandle.SetTraversalMode_InjectedDelegateField(ref _unity_self, mode);
		}

		// Token: 0x06001A2F RID: 6703 RVA: 0x0000E8CA File Offset: 0x0000CACA
		public static IntPtr GetJobData_Injected(ref PlayableHandle _unity_self)
		{
			return PlayableHandle.GetJobData_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06001A30 RID: 6704 RVA: 0x0000E8D7 File Offset: 0x0000CAD7
		public static DirectorWrapMode GetTimeWrapMode_Injected(ref PlayableHandle _unity_self)
		{
			return PlayableHandle.GetTimeWrapMode_InjectedDelegateField(ref _unity_self);
		}

		// Token: 0x06001A31 RID: 6705 RVA: 0x0000E8E4 File Offset: 0x0000CAE4
		public static void SetTimeWrapMode_Injected(ref PlayableHandle _unity_self, DirectorWrapMode mode)
		{
			PlayableHandle.SetTimeWrapMode_InjectedDelegateField(ref _unity_self, mode);
		}

		// Token: 0x06001A32 RID: 6706 RVA: 0x0005DC68 File Offset: 0x0005BE68
		public static Object GetScriptInstance_Injected(ref PlayableHandle _unity_self)
		{
			IntPtr intPtr = PlayableHandle.GetScriptInstance_InjectedDelegateField(ref _unity_self);
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
		}

		// Token: 0x06001A33 RID: 6707 RVA: 0x0000E8F2 File Offset: 0x0000CAF2
		public static void GetInputHandle_Injected(ref PlayableHandle _unity_self, int index, out PlayableHandle ret)
		{
			PlayableHandle.GetInputHandle_InjectedDelegateField(ref _unity_self, index, out ret);
		}

		// Token: 0x06001A34 RID: 6708 RVA: 0x0000E901 File Offset: 0x0000CB01
		public static void GetOutputHandle_Injected(ref PlayableHandle _unity_self, int index, out PlayableHandle ret)
		{
			PlayableHandle.GetOutputHandle_InjectedDelegateField(ref _unity_self, index, out ret);
		}

		// Token: 0x06001A35 RID: 6709 RVA: 0x0000E910 File Offset: 0x0000CB10
		public static void SetInputWeightFromIndex_Injected(ref PlayableHandle _unity_self, int index, float weight)
		{
			PlayableHandle.SetInputWeightFromIndex_InjectedDelegateField(ref _unity_self, index, weight);
		}

		// Token: 0x06001A36 RID: 6710 RVA: 0x0000E91F File Offset: 0x0000CB1F
		public static float GetInputWeightFromIndex_Injected(ref PlayableHandle _unity_self, int index)
		{
			return PlayableHandle.GetInputWeightFromIndex_InjectedDelegateField(ref _unity_self, index);
		}

		// Token: 0x040012D4 RID: 4820
		private static readonly IntPtr NativeFieldInfoPtr_m_Handle;

		// Token: 0x040012D5 RID: 4821
		private static readonly IntPtr NativeFieldInfoPtr_m_Version;

		// Token: 0x040012D6 RID: 4822
		private static readonly IntPtr NativeFieldInfoPtr_m_Null;

		// Token: 0x040012D7 RID: 4823
		private static readonly IntPtr NativeMethodInfoPtr_IsPlayableOfType_Internal_Boolean_0;

		// Token: 0x040012D8 RID: 4824
		private static readonly IntPtr NativeMethodInfoPtr_get_Null_Public_Static_get_PlayableHandle_0;

		// Token: 0x040012D9 RID: 4825
		private static readonly IntPtr NativeMethodInfoPtr_op_Equality_Public_Static_Boolean_PlayableHandle_PlayableHandle_0;

		// Token: 0x040012DA RID: 4826
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Boolean_Object_0;

		// Token: 0x040012DB RID: 4827
		private static readonly IntPtr NativeMethodInfoPtr_Equals_Public_Virtual_Final_New_Boolean_PlayableHandle_0;

		// Token: 0x040012DC RID: 4828
		private static readonly IntPtr NativeMethodInfoPtr_GetHashCode_Public_Virtual_Int32_0;

		// Token: 0x040012DD RID: 4829
		private static readonly IntPtr NativeMethodInfoPtr_CompareVersion_Internal_Static_Boolean_PlayableHandle_PlayableHandle_0;

		// Token: 0x040012DE RID: 4830
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Internal_Boolean_0;

		// Token: 0x040012DF RID: 4831
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayableType_Internal_Type_0;

		// Token: 0x040012E0 RID: 4832
		private static readonly IntPtr NativeMethodInfoPtr_IsValid_Injected_Private_Static_Boolean_byref_PlayableHandle_0;

		// Token: 0x040012E1 RID: 4833
		private static readonly IntPtr NativeMethodInfoPtr_GetPlayableType_Injected_Private_Static_Type_byref_PlayableHandle_0;

		// Token: 0x040012E2 RID: 4834
		[FieldOffset(0)]
		public IntPtr m_Handle;

		// Token: 0x040012E3 RID: 4835
		[FieldOffset(8)]
		public uint m_Version;

		// Token: 0x040012E4 RID: 4836
		private static readonly PlayableHandle.IsNull_InjectedDelegate IsNull_InjectedDelegateField;

		// Token: 0x040012E5 RID: 4837
		private static readonly PlayableHandle.GetJobType_InjectedDelegate GetJobType_InjectedDelegateField;

		// Token: 0x040012E6 RID: 4838
		private static readonly PlayableHandle.SetScriptInstance_InjectedDelegate SetScriptInstance_InjectedDelegateField;

		// Token: 0x040012E7 RID: 4839
		private static readonly PlayableHandle.CanChangeInputs_InjectedDelegate CanChangeInputs_InjectedDelegateField;

		// Token: 0x040012E8 RID: 4840
		private static readonly PlayableHandle.CanSetWeights_InjectedDelegate CanSetWeights_InjectedDelegateField;

		// Token: 0x040012E9 RID: 4841
		private static readonly PlayableHandle.CanDestroy_InjectedDelegate CanDestroy_InjectedDelegateField;

		// Token: 0x040012EA RID: 4842
		private static readonly PlayableHandle.GetPlayState_InjectedDelegate GetPlayState_InjectedDelegateField;

		// Token: 0x040012EB RID: 4843
		private static readonly PlayableHandle.Play_InjectedDelegate Play_InjectedDelegateField;

		// Token: 0x040012EC RID: 4844
		private static readonly PlayableHandle.Pause_InjectedDelegate Pause_InjectedDelegateField;

		// Token: 0x040012ED RID: 4845
		private static readonly PlayableHandle.GetSpeed_InjectedDelegate GetSpeed_InjectedDelegateField;

		// Token: 0x040012EE RID: 4846
		private static readonly PlayableHandle.SetSpeed_InjectedDelegate SetSpeed_InjectedDelegateField;

		// Token: 0x040012EF RID: 4847
		private static readonly PlayableHandle.GetTime_InjectedDelegate GetTime_InjectedDelegateField;

		// Token: 0x040012F0 RID: 4848
		private static readonly PlayableHandle.SetTime_InjectedDelegate SetTime_InjectedDelegateField;

		// Token: 0x040012F1 RID: 4849
		private static readonly PlayableHandle.IsDone_InjectedDelegate IsDone_InjectedDelegateField;

		// Token: 0x040012F2 RID: 4850
		private static readonly PlayableHandle.SetDone_InjectedDelegate SetDone_InjectedDelegateField;

		// Token: 0x040012F3 RID: 4851
		private static readonly PlayableHandle.GetDuration_InjectedDelegate GetDuration_InjectedDelegateField;

		// Token: 0x040012F4 RID: 4852
		private static readonly PlayableHandle.SetDuration_InjectedDelegate SetDuration_InjectedDelegateField;

		// Token: 0x040012F5 RID: 4853
		private static readonly PlayableHandle.GetPropagateSetTime_InjectedDelegate GetPropagateSetTime_InjectedDelegateField;

		// Token: 0x040012F6 RID: 4854
		private static readonly PlayableHandle.SetPropagateSetTime_InjectedDelegate SetPropagateSetTime_InjectedDelegateField;

		// Token: 0x040012F7 RID: 4855
		private static readonly PlayableHandle.GetGraph_InjectedDelegate GetGraph_InjectedDelegateField;

		// Token: 0x040012F8 RID: 4856
		private static readonly PlayableHandle.GetInputCount_InjectedDelegate GetInputCount_InjectedDelegateField;

		// Token: 0x040012F9 RID: 4857
		private static readonly PlayableHandle.SetInputCount_InjectedDelegate SetInputCount_InjectedDelegateField;

		// Token: 0x040012FA RID: 4858
		private static readonly PlayableHandle.GetOutputCount_InjectedDelegate GetOutputCount_InjectedDelegateField;

		// Token: 0x040012FB RID: 4859
		private static readonly PlayableHandle.SetOutputCount_InjectedDelegate SetOutputCount_InjectedDelegateField;

		// Token: 0x040012FC RID: 4860
		private static readonly PlayableHandle.SetInputWeight_InjectedDelegate SetInputWeight_InjectedDelegateField;

		// Token: 0x040012FD RID: 4861
		private static readonly PlayableHandle.SetDelay_InjectedDelegate SetDelay_InjectedDelegateField;

		// Token: 0x040012FE RID: 4862
		private static readonly PlayableHandle.GetDelay_InjectedDelegate GetDelay_InjectedDelegateField;

		// Token: 0x040012FF RID: 4863
		private static readonly PlayableHandle.IsDelayed_InjectedDelegate IsDelayed_InjectedDelegateField;

		// Token: 0x04001300 RID: 4864
		private static readonly PlayableHandle.GetPreviousTime_InjectedDelegate GetPreviousTime_InjectedDelegateField;

		// Token: 0x04001301 RID: 4865
		private static readonly PlayableHandle.SetLeadTime_InjectedDelegate SetLeadTime_InjectedDelegateField;

		// Token: 0x04001302 RID: 4866
		private static readonly PlayableHandle.GetLeadTime_InjectedDelegate GetLeadTime_InjectedDelegateField;

		// Token: 0x04001303 RID: 4867
		private static readonly PlayableHandle.GetTraversalMode_InjectedDelegate GetTraversalMode_InjectedDelegateField;

		// Token: 0x04001304 RID: 4868
		private static readonly PlayableHandle.SetTraversalMode_InjectedDelegate SetTraversalMode_InjectedDelegateField;

		// Token: 0x04001305 RID: 4869
		private static readonly PlayableHandle.GetJobData_InjectedDelegate GetJobData_InjectedDelegateField;

		// Token: 0x04001306 RID: 4870
		private static readonly PlayableHandle.GetTimeWrapMode_InjectedDelegate GetTimeWrapMode_InjectedDelegateField;

		// Token: 0x04001307 RID: 4871
		private static readonly PlayableHandle.SetTimeWrapMode_InjectedDelegate SetTimeWrapMode_InjectedDelegateField;

		// Token: 0x04001308 RID: 4872
		private static readonly PlayableHandle.GetScriptInstance_InjectedDelegate GetScriptInstance_InjectedDelegateField;

		// Token: 0x04001309 RID: 4873
		private static readonly PlayableHandle.GetInputHandle_InjectedDelegate GetInputHandle_InjectedDelegateField;

		// Token: 0x0400130A RID: 4874
		private static readonly PlayableHandle.GetOutputHandle_InjectedDelegate GetOutputHandle_InjectedDelegateField;

		// Token: 0x0400130B RID: 4875
		private static readonly PlayableHandle.SetInputWeightFromIndex_InjectedDelegate SetInputWeightFromIndex_InjectedDelegateField;

		// Token: 0x0400130C RID: 4876
		private static readonly PlayableHandle.GetInputWeightFromIndex_InjectedDelegate GetInputWeightFromIndex_InjectedDelegateField;

		// Token: 0x020009C9 RID: 2505
		private sealed class MethodInfoStoreGeneric_IsPlayableOfType_Internal_Boolean_0<T>
		{
			// Token: 0x04001D37 RID: 7479
			internal static IntPtr Pointer = IL2CPP.il2cpp_method_get_from_reflection(IL2CPP.Il2CppObjectBaseToPtrNotNull(new MethodInfo(IL2CPP.il2cpp_method_get_object(PlayableHandle.NativeMethodInfoPtr_IsPlayableOfType_Internal_Boolean_0, Il2CppClassPointerStore<PlayableHandle>.NativeClassPtr)).MakeGenericMethod(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<T>.NativeClassPtr)) }))));
		}

		// Token: 0x020009CA RID: 2506
		// (Invoke) Token: 0x060031B3 RID: 12723
		private delegate bool IsNull_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x020009CB RID: 2507
		// (Invoke) Token: 0x060031B5 RID: 12725
		private delegate IntPtr GetJobType_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x020009CC RID: 2508
		// (Invoke) Token: 0x060031B7 RID: 12727
		private delegate void SetScriptInstance_InjectedDelegate(IntPtr _unity_self, IntPtr scriptInstance);

		// Token: 0x020009CD RID: 2509
		// (Invoke) Token: 0x060031B9 RID: 12729
		private delegate bool CanChangeInputs_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x020009CE RID: 2510
		// (Invoke) Token: 0x060031BB RID: 12731
		private delegate bool CanSetWeights_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x020009CF RID: 2511
		// (Invoke) Token: 0x060031BD RID: 12733
		private delegate bool CanDestroy_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x020009D0 RID: 2512
		// (Invoke) Token: 0x060031BF RID: 12735
		private delegate PlayState GetPlayState_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x020009D1 RID: 2513
		// (Invoke) Token: 0x060031C1 RID: 12737
		private delegate void Play_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x020009D2 RID: 2514
		// (Invoke) Token: 0x060031C3 RID: 12739
		private delegate void Pause_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x020009D3 RID: 2515
		// (Invoke) Token: 0x060031C5 RID: 12741
		private delegate double GetSpeed_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x020009D4 RID: 2516
		// (Invoke) Token: 0x060031C7 RID: 12743
		private delegate void SetSpeed_InjectedDelegate(IntPtr _unity_self, double value);

		// Token: 0x020009D5 RID: 2517
		// (Invoke) Token: 0x060031C9 RID: 12745
		private delegate double GetTime_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x020009D6 RID: 2518
		// (Invoke) Token: 0x060031CB RID: 12747
		private delegate void SetTime_InjectedDelegate(IntPtr _unity_self, double value);

		// Token: 0x020009D7 RID: 2519
		// (Invoke) Token: 0x060031CD RID: 12749
		private delegate bool IsDone_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x020009D8 RID: 2520
		// (Invoke) Token: 0x060031CF RID: 12751
		private delegate void SetDone_InjectedDelegate(IntPtr _unity_self, bool value);

		// Token: 0x020009D9 RID: 2521
		// (Invoke) Token: 0x060031D1 RID: 12753
		private delegate double GetDuration_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x020009DA RID: 2522
		// (Invoke) Token: 0x060031D3 RID: 12755
		private delegate void SetDuration_InjectedDelegate(IntPtr _unity_self, double value);

		// Token: 0x020009DB RID: 2523
		// (Invoke) Token: 0x060031D5 RID: 12757
		private delegate bool GetPropagateSetTime_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x020009DC RID: 2524
		// (Invoke) Token: 0x060031D7 RID: 12759
		private delegate void SetPropagateSetTime_InjectedDelegate(IntPtr _unity_self, bool value);

		// Token: 0x020009DD RID: 2525
		// (Invoke) Token: 0x060031D9 RID: 12761
		private delegate void GetGraph_InjectedDelegate(IntPtr _unity_self, [Out] IntPtr ret);

		// Token: 0x020009DE RID: 2526
		// (Invoke) Token: 0x060031DB RID: 12763
		private delegate int GetInputCount_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x020009DF RID: 2527
		// (Invoke) Token: 0x060031DD RID: 12765
		private delegate void SetInputCount_InjectedDelegate(IntPtr _unity_self, int value);

		// Token: 0x020009E0 RID: 2528
		// (Invoke) Token: 0x060031DF RID: 12767
		private delegate int GetOutputCount_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x020009E1 RID: 2529
		// (Invoke) Token: 0x060031E1 RID: 12769
		private delegate void SetOutputCount_InjectedDelegate(IntPtr _unity_self, int value);

		// Token: 0x020009E2 RID: 2530
		// (Invoke) Token: 0x060031E3 RID: 12771
		private delegate void SetInputWeight_InjectedDelegate(IntPtr _unity_self, IntPtr input, float weight);

		// Token: 0x020009E3 RID: 2531
		// (Invoke) Token: 0x060031E5 RID: 12773
		private delegate void SetDelay_InjectedDelegate(IntPtr _unity_self, double delay);

		// Token: 0x020009E4 RID: 2532
		// (Invoke) Token: 0x060031E7 RID: 12775
		private delegate double GetDelay_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x020009E5 RID: 2533
		// (Invoke) Token: 0x060031E9 RID: 12777
		private delegate bool IsDelayed_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x020009E6 RID: 2534
		// (Invoke) Token: 0x060031EB RID: 12779
		private delegate double GetPreviousTime_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x020009E7 RID: 2535
		// (Invoke) Token: 0x060031ED RID: 12781
		private delegate void SetLeadTime_InjectedDelegate(IntPtr _unity_self, float value);

		// Token: 0x020009E8 RID: 2536
		// (Invoke) Token: 0x060031EF RID: 12783
		private delegate float GetLeadTime_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x020009E9 RID: 2537
		// (Invoke) Token: 0x060031F1 RID: 12785
		private delegate PlayableTraversalMode GetTraversalMode_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x020009EA RID: 2538
		// (Invoke) Token: 0x060031F3 RID: 12787
		private delegate void SetTraversalMode_InjectedDelegate(IntPtr _unity_self, PlayableTraversalMode mode);

		// Token: 0x020009EB RID: 2539
		// (Invoke) Token: 0x060031F5 RID: 12789
		private delegate IntPtr GetJobData_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x020009EC RID: 2540
		// (Invoke) Token: 0x060031F7 RID: 12791
		private delegate DirectorWrapMode GetTimeWrapMode_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x020009ED RID: 2541
		// (Invoke) Token: 0x060031F9 RID: 12793
		private delegate void SetTimeWrapMode_InjectedDelegate(IntPtr _unity_self, DirectorWrapMode mode);

		// Token: 0x020009EE RID: 2542
		// (Invoke) Token: 0x060031FB RID: 12795
		private delegate IntPtr GetScriptInstance_InjectedDelegate(IntPtr _unity_self);

		// Token: 0x020009EF RID: 2543
		// (Invoke) Token: 0x060031FD RID: 12797
		private delegate void GetInputHandle_InjectedDelegate(IntPtr _unity_self, int index, [Out] IntPtr ret);

		// Token: 0x020009F0 RID: 2544
		// (Invoke) Token: 0x060031FF RID: 12799
		private delegate void GetOutputHandle_InjectedDelegate(IntPtr _unity_self, int index, [Out] IntPtr ret);

		// Token: 0x020009F1 RID: 2545
		// (Invoke) Token: 0x06003201 RID: 12801
		private delegate void SetInputWeightFromIndex_InjectedDelegate(IntPtr _unity_self, int index, float weight);

		// Token: 0x020009F2 RID: 2546
		// (Invoke) Token: 0x06003203 RID: 12803
		private delegate float GetInputWeightFromIndex_InjectedDelegate(IntPtr _unity_self, int index);
	}
}
