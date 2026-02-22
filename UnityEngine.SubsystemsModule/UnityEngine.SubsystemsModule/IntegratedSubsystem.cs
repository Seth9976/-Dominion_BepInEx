using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000002 RID: 2
	public class IntegratedSubsystem : Object
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002608 File Offset: 0x00000808
		// Note: this type is marked as 'beforefieldinit'.
		static IntegratedSubsystem()
		{
			Il2CppClassPointerStore<IntegratedSubsystem>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.SubsystemsModule.dll", "UnityEngine", "IntegratedSubsystem");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntegratedSubsystem>.NativeClassPtr);
			IntegratedSubsystem.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntegratedSubsystem>.NativeClassPtr, "m_Ptr");
			IntegratedSubsystem.NativeFieldInfoPtr_m_SubsystemDescriptor = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<IntegratedSubsystem>.NativeClassPtr, "m_SubsystemDescriptor");
			IntegratedSubsystem.NativeMethodInfoPtr_SetHandle_Internal_Void_IntegratedSubsystem_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegratedSubsystem>.NativeClassPtr, 100663297);
			IntegratedSubsystem.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegratedSubsystem>.NativeClassPtr, 100663298);
			IntegratedSubsystem.StartDelegateField = IL2CPP.ResolveICall<IntegratedSubsystem.StartDelegate>("UnityEngine.IntegratedSubsystem::Start");
			IntegratedSubsystem.StopDelegateField = IL2CPP.ResolveICall<IntegratedSubsystem.StopDelegate>("UnityEngine.IntegratedSubsystem::Stop");
			IntegratedSubsystem.IsRunningDelegateField = IL2CPP.ResolveICall<IntegratedSubsystem.IsRunningDelegate>("UnityEngine.IntegratedSubsystem::IsRunning");
		}

		// Token: 0x06000002 RID: 2 RVA: 0x000026B8 File Offset: 0x000008B8
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 131451, XrefRangeEnd = 131453, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void SetHandle(IntegratedSubsystem subsystem)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(subsystem);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntegratedSubsystem.NativeMethodInfoPtr_SetHandle_Internal_Void_IntegratedSubsystem_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x06000003 RID: 3 RVA: 0x000026FC File Offset: 0x000008FC
		[CallerCount(817)]
		[CachedScanResults(RefRangeStart = 5401, RefRangeEnd = 6218, XrefRangeStart = 5401, XrefRangeEnd = 6218, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntegratedSubsystem()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntegratedSubsystem>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntegratedSubsystem.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002050 File Offset: 0x00000250
		public IntegratedSubsystem(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000005 RID: 5 RVA: 0x00002738 File Offset: 0x00000938
		// (set) Token: 0x06000006 RID: 6 RVA: 0x00002059 File Offset: 0x00000259
		public unsafe IntPtr m_Ptr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntegratedSubsystem.NativeFieldInfoPtr_m_Ptr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntegratedSubsystem.NativeFieldInfoPtr_m_Ptr)) = value;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000007 RID: 7 RVA: 0x00002760 File Offset: 0x00000960
		// (set) Token: 0x06000008 RID: 8 RVA: 0x00002074 File Offset: 0x00000274
		public unsafe ISubsystemDescriptor m_SubsystemDescriptor
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntegratedSubsystem.NativeFieldInfoPtr_m_SubsystemDescriptor);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<ISubsystemDescriptor>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(IntegratedSubsystem.NativeFieldInfoPtr_m_SubsystemDescriptor), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002093 File Offset: 0x00000293
		public void Start()
		{
			IntegratedSubsystem.StartDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000020A5 File Offset: 0x000002A5
		public void Stop()
		{
			IntegratedSubsystem.StopDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002790 File Offset: 0x00000990
		public void Destroy()
		{
			IntPtr ptr = this.m_Ptr;
			SubsystemManager.RemoveIntegratedSubsystemByPtr(this.m_Ptr);
			SubsystemBindings.DestroySubsystem(ptr);
			this.m_Ptr = IntPtr.Zero;
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000C RID: 12 RVA: 0x000020B7 File Offset: 0x000002B7
		public bool running
		{
			get
			{
				return this.valid && this.IsRunning();
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000D RID: 13 RVA: 0x000020CA File Offset: 0x000002CA
		public bool valid
		{
			get
			{
				return this.m_Ptr != IntPtr.Zero;
			}
		}

		// Token: 0x0600000E RID: 14 RVA: 0x000020DC File Offset: 0x000002DC
		public bool IsRunning()
		{
			return IntegratedSubsystem.IsRunningDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x04000001 RID: 1
		private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

		// Token: 0x04000002 RID: 2
		private static readonly IntPtr NativeFieldInfoPtr_m_SubsystemDescriptor;

		// Token: 0x04000003 RID: 3
		private static readonly IntPtr NativeMethodInfoPtr_SetHandle_Internal_Void_IntegratedSubsystem_0;

		// Token: 0x04000004 RID: 4
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x04000005 RID: 5
		private static readonly IntegratedSubsystem.StartDelegate StartDelegateField;

		// Token: 0x04000006 RID: 6
		private static readonly IntegratedSubsystem.StopDelegate StopDelegateField;

		// Token: 0x04000007 RID: 7
		private static readonly IntegratedSubsystem.IsRunningDelegate IsRunningDelegateField;

		// Token: 0x02000017 RID: 23
		// (Invoke) Token: 0x06000091 RID: 145
		private delegate void StartDelegate(IntPtr @this);

		// Token: 0x02000018 RID: 24
		// (Invoke) Token: 0x06000093 RID: 147
		private delegate void StopDelegate(IntPtr @this);

		// Token: 0x02000019 RID: 25
		// (Invoke) Token: 0x06000095 RID: 149
		private delegate bool IsRunningDelegate(IntPtr @this);
	}
}
