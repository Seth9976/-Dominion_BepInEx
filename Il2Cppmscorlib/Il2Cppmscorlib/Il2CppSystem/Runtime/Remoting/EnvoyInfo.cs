using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem.Runtime.Remoting.Messaging;

namespace Il2CppSystem.Runtime.Remoting
{
	// Token: 0x0200038D RID: 909
	[Serializable]
	public class EnvoyInfo : Object
	{
		// Token: 0x06003B32 RID: 15154 RVA: 0x00117C58 File Offset: 0x00115E58
		// Note: this type is marked as 'beforefieldinit'.
		static EnvoyInfo()
		{
			Il2CppClassPointerStore<EnvoyInfo>.NativeClassPtr = IL2CPP.GetIl2CppClass("mscorlib.dll", "System.Runtime.Remoting", "EnvoyInfo");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<EnvoyInfo>.NativeClassPtr);
			EnvoyInfo.NativeFieldInfoPtr_envoySinks = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<EnvoyInfo>.NativeClassPtr, "envoySinks");
			EnvoyInfo.NativeMethodInfoPtr__ctor_Public_Void_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvoyInfo>.NativeClassPtr, 100672053);
			EnvoyInfo.NativeMethodInfoPtr_get_EnvoySinks_Public_Virtual_Final_New_get_IMessageSink_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<EnvoyInfo>.NativeClassPtr, 100672054);
		}

		// Token: 0x06003B33 RID: 15155 RVA: 0x00117CC4 File Offset: 0x00115EC4
		[CallerCount(50)]
		[CachedScanResults(RefRangeStart = 12224, RefRangeEnd = 12274, XrefRangeStart = 12224, XrefRangeEnd = 12274, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe EnvoyInfo(IMessageSink sinks)
			: this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<EnvoyInfo>.NativeClassPtr))
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(sinks);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvoyInfo.NativeMethodInfoPtr__ctor_Public_Void_IMessageSink_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}
		}

		// Token: 0x17000EC3 RID: 3779
		// (get) Token: 0x06003B34 RID: 15156 RVA: 0x00117D10 File Offset: 0x00115F10
		public unsafe virtual IMessageSink EnvoySinks
		{
			[CallerCount(7)]
			[CachedScanResults(RefRangeStart = 5319, RefRangeEnd = 5326, XrefRangeStart = 5319, XrefRangeEnd = 5326, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(EnvoyInfo.NativeMethodInfoPtr_get_EnvoySinks_Public_Virtual_Final_New_get_IMessageSink_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr3) : null;
			}
		}

		// Token: 0x06003B35 RID: 15157 RVA: 0x00016460 File Offset: 0x00014660
		public EnvoyInfo(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000EC2 RID: 3778
		// (get) Token: 0x06003B36 RID: 15158 RVA: 0x00117D50 File Offset: 0x00115F50
		// (set) Token: 0x06003B37 RID: 15159 RVA: 0x00016469 File Offset: 0x00014669
		public unsafe IMessageSink envoySinks
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvoyInfo.NativeFieldInfoPtr_envoySinks);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<IMessageSink>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(EnvoyInfo.NativeFieldInfoPtr_envoySinks), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0400314E RID: 12622
		private static readonly IntPtr NativeFieldInfoPtr_envoySinks;

		// Token: 0x0400314F RID: 12623
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_IMessageSink_0;

		// Token: 0x04003150 RID: 12624
		private static readonly IntPtr NativeMethodInfoPtr_get_EnvoySinks_Public_Virtual_Final_New_get_IMessageSink_0;
	}
}
