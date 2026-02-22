using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000005 RID: 5
	public class IntegratedSubsystemDescriptor<TSubsystem> : IntegratedSubsystemDescriptor where TSubsystem : IntegratedSubsystem
	{
		// Token: 0x0600001D RID: 29 RVA: 0x00002988 File Offset: 0x00000B88
		// Note: this type is marked as 'beforefieldinit'.
		static IntegratedSubsystemDescriptor()
		{
			Il2CppClassPointerStore<IntegratedSubsystemDescriptor<TSubsystem>>.NativeClassPtr = IL2CPP.il2cpp_class_from_type(Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(IL2CPP.GetIl2CppClass("UnityEngine.SubsystemsModule.dll", "UnityEngine", "IntegratedSubsystemDescriptor`1"))).MakeGenericType(new Il2CppReferenceArray<Type>(new Type[] { Type.internal_from_handle(IL2CPP.il2cpp_class_get_type(Il2CppClassPointerStore<TSubsystem>.NativeClassPtr)) })).TypeHandle.value);
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<IntegratedSubsystemDescriptor<TSubsystem>>.NativeClassPtr);
			IntegratedSubsystemDescriptor<TSubsystem>.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<IntegratedSubsystemDescriptor<TSubsystem>>.NativeClassPtr, 100663302);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002A08 File Offset: 0x00000C08
		[CallerCount(6)]
		[CachedScanResults(RefRangeStart = 131455, RefRangeEnd = 131461, XrefRangeStart = 131455, XrefRangeEnd = 131461, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe IntegratedSubsystemDescriptor()
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<IntegratedSubsystemDescriptor<TSubsystem>>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IntegratedSubsystemDescriptor<TSubsystem>.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002149 File Offset: 0x00000349
		public IntegratedSubsystemDescriptor(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002A44 File Offset: 0x00000C44
		public override ISubsystem CreateImpl()
		{
			return this.Create();
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00002A64 File Offset: 0x00000C64
		public TSubsystem Create()
		{
			IntPtr intPtr = SubsystemDescriptorBindings.Create(base.m_Ptr);
			TSubsystem tsubsystem = SubsystemManager.GetIntegratedSubsystemByPtr(intPtr).Cast<TSubsystem>();
			bool flag = tsubsystem != null;
			if (flag)
			{
				tsubsystem.m_SubsystemDescriptor = this;
			}
			return tsubsystem;
		}

		// Token: 0x0400000C RID: 12
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
