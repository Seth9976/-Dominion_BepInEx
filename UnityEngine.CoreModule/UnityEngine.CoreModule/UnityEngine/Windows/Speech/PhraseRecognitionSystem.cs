using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine.Windows.Speech
{
	// Token: 0x020000EB RID: 235
	public static class PhraseRecognitionSystem : Object
	{
		// Token: 0x06001476 RID: 5238 RVA: 0x0004EB9C File Offset: 0x0004CD9C
		// Note: this type is marked as 'beforefieldinit'.
		static PhraseRecognitionSystem()
		{
			Il2CppClassPointerStore<PhraseRecognitionSystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine.Windows.Speech", "PhraseRecognitionSystem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<PhraseRecognitionSystem>.NativeClassPtr);
			PhraseRecognitionSystem.NativeFieldInfoPtr_OnError = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhraseRecognitionSystem>.NativeClassPtr, "OnError");
			PhraseRecognitionSystem.NativeFieldInfoPtr_OnStatusChanged = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<PhraseRecognitionSystem>.NativeClassPtr, "OnStatusChanged");
			PhraseRecognitionSystem.NativeMethodInfoPtr_PhraseRecognitionSystem_InvokeErrorEvent_Private_Static_Void_SpeechError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhraseRecognitionSystem>.NativeClassPtr, 100664768);
			PhraseRecognitionSystem.NativeMethodInfoPtr_PhraseRecognitionSystem_InvokeStatusChangedEvent_Private_Static_Void_SpeechSystemStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhraseRecognitionSystem>.NativeClassPtr, 100664769);
			PhraseRecognitionSystem.get_isSupportedDelegateField = IL2CPP.ResolveICall<PhraseRecognitionSystem.get_isSupportedDelegate>("UnityEngine.Windows.Speech.PhraseRecognitionSystem::get_isSupported");
			PhraseRecognitionSystem.get_StatusDelegateField = IL2CPP.ResolveICall<PhraseRecognitionSystem.get_StatusDelegate>("UnityEngine.Windows.Speech.PhraseRecognitionSystem::get_Status");
			PhraseRecognitionSystem.RestartDelegateField = IL2CPP.ResolveICall<PhraseRecognitionSystem.RestartDelegate>("UnityEngine.Windows.Speech.PhraseRecognitionSystem::Restart");
			PhraseRecognitionSystem.ShutdownDelegateField = IL2CPP.ResolveICall<PhraseRecognitionSystem.ShutdownDelegate>("UnityEngine.Windows.Speech.PhraseRecognitionSystem::Shutdown");
		}

		// Token: 0x06001477 RID: 5239 RVA: 0x0004EC58 File Offset: 0x0004CE58
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79617, XrefRangeEnd = 79620, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PhraseRecognitionSystem_InvokeErrorEvent(SpeechError errorCode)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref errorCode;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhraseRecognitionSystem.NativeMethodInfoPtr_PhraseRecognitionSystem_InvokeErrorEvent_Private_Static_Void_SpeechError_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001478 RID: 5240 RVA: 0x0004EC8C File Offset: 0x0004CE8C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 79620, XrefRangeEnd = 79623, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void PhraseRecognitionSystem_InvokeStatusChangedEvent(SpeechSystemStatus status)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref status;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhraseRecognitionSystem.NativeMethodInfoPtr_PhraseRecognitionSystem_InvokeStatusChangedEvent_Private_Static_Void_SpeechSystemStatus_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06001479 RID: 5241 RVA: 0x0000BC70 File Offset: 0x00009E70
		public PhraseRecognitionSystem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000477 RID: 1143
		// (get) Token: 0x0600147A RID: 5242 RVA: 0x0004ECC0 File Offset: 0x0004CEC0
		// (set) Token: 0x0600147B RID: 5243 RVA: 0x0000BC79 File Offset: 0x00009E79
		public unsafe static PhraseRecognitionSystem.ErrorDelegate OnError
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PhraseRecognitionSystem.NativeFieldInfoPtr_OnError, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhraseRecognitionSystem.ErrorDelegate>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PhraseRecognitionSystem.NativeFieldInfoPtr_OnError, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000478 RID: 1144
		// (get) Token: 0x0600147C RID: 5244 RVA: 0x0004ECE8 File Offset: 0x0004CEE8
		// (set) Token: 0x0600147D RID: 5245 RVA: 0x0000BC8B File Offset: 0x00009E8B
		public unsafe static PhraseRecognitionSystem.StatusDelegate OnStatusChanged
		{
			get
			{
				IntPtr intPtr;
				IL2CPP.il2cpp_field_static_get_value(PhraseRecognitionSystem.NativeFieldInfoPtr_OnStatusChanged, (void*)(&intPtr));
				IntPtr intPtr2 = intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<PhraseRecognitionSystem.StatusDelegate>(intPtr2) : null;
			}
			set
			{
				IL2CPP.il2cpp_field_static_set_value(PhraseRecognitionSystem.NativeFieldInfoPtr_OnStatusChanged, IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17000479 RID: 1145
		// (get) Token: 0x0600147E RID: 5246 RVA: 0x0000BC9D File Offset: 0x00009E9D
		public static bool isSupported
		{
			get
			{
				return PhraseRecognitionSystem.get_isSupportedDelegateField();
			}
		}

		// Token: 0x1700047A RID: 1146
		// (get) Token: 0x0600147F RID: 5247 RVA: 0x0000BCA9 File Offset: 0x00009EA9
		public static SpeechSystemStatus Status
		{
			get
			{
				return PhraseRecognitionSystem.get_StatusDelegateField();
			}
		}

		// Token: 0x06001480 RID: 5248 RVA: 0x0000BCB5 File Offset: 0x00009EB5
		public static void Restart()
		{
			PhraseRecognitionSystem.RestartDelegateField();
		}

		// Token: 0x06001481 RID: 5249 RVA: 0x0000BCC1 File Offset: 0x00009EC1
		public static void Shutdown()
		{
			PhraseRecognitionSystem.ShutdownDelegateField();
		}

		// Token: 0x06001482 RID: 5250 RVA: 0x0000BCCD File Offset: 0x00009ECD
		public static void add_OnError(PhraseRecognitionSystem.ErrorDelegate value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001483 RID: 5251 RVA: 0x0000BCDA File Offset: 0x00009EDA
		public static void remove_OnError(PhraseRecognitionSystem.ErrorDelegate value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001484 RID: 5252 RVA: 0x0000BCE7 File Offset: 0x00009EE7
		public static void add_OnStatusChanged(PhraseRecognitionSystem.StatusDelegate value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x06001485 RID: 5253 RVA: 0x0000BCF4 File Offset: 0x00009EF4
		public static void remove_OnStatusChanged(PhraseRecognitionSystem.StatusDelegate value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x04000F3B RID: 3899
		private static readonly IntPtr NativeFieldInfoPtr_OnError;

		// Token: 0x04000F3C RID: 3900
		private static readonly IntPtr NativeFieldInfoPtr_OnStatusChanged;

		// Token: 0x04000F3D RID: 3901
		private static readonly IntPtr NativeMethodInfoPtr_PhraseRecognitionSystem_InvokeErrorEvent_Private_Static_Void_SpeechError_0;

		// Token: 0x04000F3E RID: 3902
		private static readonly IntPtr NativeMethodInfoPtr_PhraseRecognitionSystem_InvokeStatusChangedEvent_Private_Static_Void_SpeechSystemStatus_0;

		// Token: 0x04000F3F RID: 3903
		private static readonly PhraseRecognitionSystem.get_isSupportedDelegate get_isSupportedDelegateField;

		// Token: 0x04000F40 RID: 3904
		private static readonly PhraseRecognitionSystem.get_StatusDelegate get_StatusDelegateField;

		// Token: 0x04000F41 RID: 3905
		private static readonly PhraseRecognitionSystem.RestartDelegate RestartDelegateField;

		// Token: 0x04000F42 RID: 3906
		private static readonly PhraseRecognitionSystem.ShutdownDelegate ShutdownDelegateField;

		// Token: 0x02000887 RID: 2183
		public sealed class ErrorDelegate : MulticastDelegate
		{
			// Token: 0x06002EC0 RID: 11968 RVA: 0x0001557B File Offset: 0x0001377B
			// Note: this type is marked as 'beforefieldinit'.
			static ErrorDelegate()
			{
				Il2CppClassPointerStore<PhraseRecognitionSystem.ErrorDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PhraseRecognitionSystem>.NativeClassPtr, "ErrorDelegate");
				PhraseRecognitionSystem.ErrorDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhraseRecognitionSystem.ErrorDelegate>.NativeClassPtr, 100664770);
				PhraseRecognitionSystem.ErrorDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_SpeechError_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhraseRecognitionSystem.ErrorDelegate>.NativeClassPtr, 100664771);
			}

			// Token: 0x06002EC1 RID: 11969 RVA: 0x0006CE6C File Offset: 0x0006B06C
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe ErrorDelegate(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhraseRecognitionSystem.ErrorDelegate>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhraseRecognitionSystem.ErrorDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002EC2 RID: 11970 RVA: 0x0006CEC8 File Offset: 0x0006B0C8
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 79599, RefRangeEnd = 79617, XrefRangeStart = 79594, XrefRangeEnd = 79599, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(SpeechError errorCode)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref errorCode;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhraseRecognitionSystem.ErrorDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_SpeechError_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002EC3 RID: 11971 RVA: 0x000155B9 File Offset: 0x000137B9
			public ErrorDelegate(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002EC4 RID: 11972 RVA: 0x000155C2 File Offset: 0x000137C2
			public static implicit operator PhraseRecognitionSystem.ErrorDelegate(Action<SpeechError> A_0)
			{
				return DelegateSupport.ConvertDelegate<PhraseRecognitionSystem.ErrorDelegate>(A_0);
			}

			// Token: 0x06002EC5 RID: 11973 RVA: 0x000155CA File Offset: 0x000137CA
			public static PhraseRecognitionSystem.ErrorDelegate operator +(PhraseRecognitionSystem.ErrorDelegate A_0, PhraseRecognitionSystem.ErrorDelegate A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<PhraseRecognitionSystem.ErrorDelegate>();
			}

			// Token: 0x06002EC6 RID: 11974 RVA: 0x000155D8 File Offset: 0x000137D8
			public static PhraseRecognitionSystem.ErrorDelegate operator -(PhraseRecognitionSystem.ErrorDelegate A_0, PhraseRecognitionSystem.ErrorDelegate A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<PhraseRecognitionSystem.ErrorDelegate>();
				}
				return delegate2;
			}

			// Token: 0x04001CC6 RID: 7366
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001CC7 RID: 7367
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_SpeechError_0;
		}

		// Token: 0x02000888 RID: 2184
		public sealed class StatusDelegate : MulticastDelegate
		{
			// Token: 0x06002EC7 RID: 11975 RVA: 0x000155E9 File Offset: 0x000137E9
			// Note: this type is marked as 'beforefieldinit'.
			static StatusDelegate()
			{
				Il2CppClassPointerStore<PhraseRecognitionSystem.StatusDelegate>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<PhraseRecognitionSystem>.NativeClassPtr, "StatusDelegate");
				PhraseRecognitionSystem.StatusDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhraseRecognitionSystem.StatusDelegate>.NativeClassPtr, 100664772);
				PhraseRecognitionSystem.StatusDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_SpeechSystemStatus_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<PhraseRecognitionSystem.StatusDelegate>.NativeClassPtr, 100664773);
			}

			// Token: 0x06002EC8 RID: 11976 RVA: 0x0006CF08 File Offset: 0x0006B108
			[CallerCount(1135)]
			[CachedScanResults(RefRangeStart = 9068, RefRangeEnd = 10203, XrefRangeStart = 9068, XrefRangeEnd = 10203, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe StatusDelegate(Object @object, IntPtr method)
				: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<PhraseRecognitionSystem.StatusDelegate>.NativeClassPtr))
			{
				IntPtr* ptr;
				checked
				{
					ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
					*ptr = IL2CPP.Il2CppObjectBaseToPtr(@object);
				}
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref method;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhraseRecognitionSystem.StatusDelegate.NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x06002EC9 RID: 11977 RVA: 0x0006CF64 File Offset: 0x0006B164
			[CallerCount(18)]
			[CachedScanResults(RefRangeStart = 79599, RefRangeEnd = 79617, XrefRangeStart = 79599, XrefRangeEnd = 79617, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Invoke(SpeechSystemStatus status)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				checked
				{
					IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
					*ptr = ref status;
					IntPtr intPtr2;
					IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(PhraseRecognitionSystem.StatusDelegate.NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_SpeechSystemStatus_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
					Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				}
			}

			// Token: 0x06002ECA RID: 11978 RVA: 0x00015627 File Offset: 0x00013827
			public StatusDelegate(IntPtr pointer)
				: base(pointer)
			{
			}

			// Token: 0x06002ECB RID: 11979 RVA: 0x00015630 File Offset: 0x00013830
			public static implicit operator PhraseRecognitionSystem.StatusDelegate(Action<SpeechSystemStatus> A_0)
			{
				return DelegateSupport.ConvertDelegate<PhraseRecognitionSystem.StatusDelegate>(A_0);
			}

			// Token: 0x06002ECC RID: 11980 RVA: 0x00015638 File Offset: 0x00013838
			public static PhraseRecognitionSystem.StatusDelegate operator +(PhraseRecognitionSystem.StatusDelegate A_0, PhraseRecognitionSystem.StatusDelegate A_1)
			{
				return Delegate.Combine(A_0, A_1).Cast<PhraseRecognitionSystem.StatusDelegate>();
			}

			// Token: 0x06002ECD RID: 11981 RVA: 0x00015646 File Offset: 0x00013846
			public static PhraseRecognitionSystem.StatusDelegate operator -(PhraseRecognitionSystem.StatusDelegate A_0, PhraseRecognitionSystem.StatusDelegate A_1)
			{
				Delegate delegate2;
				Delegate @delegate = (delegate2 = Delegate.Remove(A_0, A_1));
				if (@delegate != null)
				{
					delegate2 = @delegate.Cast<PhraseRecognitionSystem.StatusDelegate>();
				}
				return delegate2;
			}

			// Token: 0x04001CC8 RID: 7368
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Object_IntPtr_0;

			// Token: 0x04001CC9 RID: 7369
			private static readonly IntPtr NativeMethodInfoPtr_Invoke_Public_Virtual_New_Void_SpeechSystemStatus_0;
		}

		// Token: 0x02000889 RID: 2185
		// (Invoke) Token: 0x06002ECF RID: 11983
		private delegate bool get_isSupportedDelegate();

		// Token: 0x0200088A RID: 2186
		// (Invoke) Token: 0x06002ED1 RID: 11985
		private delegate SpeechSystemStatus get_StatusDelegate();

		// Token: 0x0200088B RID: 2187
		// (Invoke) Token: 0x06002ED3 RID: 11987
		private delegate void RestartDelegate();

		// Token: 0x0200088C RID: 2188
		// (Invoke) Token: 0x06002ED5 RID: 11989
		private delegate void ShutdownDelegate();
	}
}
