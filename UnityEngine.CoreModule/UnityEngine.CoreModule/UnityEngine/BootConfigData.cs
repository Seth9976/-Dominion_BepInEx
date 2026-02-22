using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x02000038 RID: 56
	public class BootConfigData : Object
	{
		// Token: 0x0600021E RID: 542 RVA: 0x0001BA1C File Offset: 0x00019C1C
		// Note: this type is marked as 'beforefieldinit'.
		static BootConfigData()
		{
			Il2CppClassPointerStore<BootConfigData>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "BootConfigData");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<BootConfigData>.NativeClassPtr);
			BootConfigData.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<BootConfigData>.NativeClassPtr, "m_Ptr");
			BootConfigData.NativeMethodInfoPtr_WrapBootConfigData_Private_Static_BootConfigData_IntPtr_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<BootConfigData>.NativeClassPtr, 100663399);
			BootConfigData.AppendDelegateField = IL2CPP.ResolveICall<BootConfigData.AppendDelegate>("UnityEngine.BootConfigData::Append");
			BootConfigData.SetDelegateField = IL2CPP.ResolveICall<BootConfigData.SetDelegate>("UnityEngine.BootConfigData::Set");
			BootConfigData.GetValueDelegateField = IL2CPP.ResolveICall<BootConfigData.GetValueDelegate>("UnityEngine.BootConfigData::GetValue");
		}

		// Token: 0x0600021F RID: 543 RVA: 0x0001BAA4 File Offset: 0x00019CA4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 59618, XrefRangeEnd = 59624, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static BootConfigData WrapBootConfigData(IntPtr nativeHandle)
		{
			checked
			{
				IntPtr* ptr = stackalloc IntPtr[unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)];
				*ptr = ref nativeHandle;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(BootConfigData.NativeMethodInfoPtr_WrapBootConfigData_Private_Static_BootConfigData_IntPtr_0, 0, (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				IntPtr intPtr3 = intPtr;
				return (intPtr3 != 0) ? Il2CppObjectPool.Get<BootConfigData>(intPtr3) : null;
			}
		}

		// Token: 0x06000220 RID: 544 RVA: 0x0000347E File Offset: 0x0000167E
		public BootConfigData(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000221 RID: 545 RVA: 0x0001BAE4 File Offset: 0x00019CE4
		// (set) Token: 0x06000222 RID: 546 RVA: 0x00003487 File Offset: 0x00001687
		public unsafe IntPtr m_Ptr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BootConfigData.NativeFieldInfoPtr_m_Ptr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(BootConfigData.NativeFieldInfoPtr_m_Ptr)) = value;
			}
		}

		// Token: 0x06000223 RID: 547 RVA: 0x000034A2 File Offset: 0x000016A2
		public void AddKey(string key)
		{
			this.Append(key, null);
		}

		// Token: 0x06000224 RID: 548 RVA: 0x0001BB0C File Offset: 0x00019D0C
		public string Get(string key)
		{
			return this.GetValue(key, 0);
		}

		// Token: 0x06000225 RID: 549 RVA: 0x0001BB28 File Offset: 0x00019D28
		public string Get(string key, int index)
		{
			return this.GetValue(key, index);
		}

		// Token: 0x06000226 RID: 550 RVA: 0x000034AE File Offset: 0x000016AE
		public void Append(string key, string value)
		{
			BootConfigData.AppendDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(key), IL2CPP.ManagedStringToIl2Cpp(value));
		}

		// Token: 0x06000227 RID: 551 RVA: 0x000034CC File Offset: 0x000016CC
		public void Set(string key, string value)
		{
			BootConfigData.SetDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(key), IL2CPP.ManagedStringToIl2Cpp(value));
		}

		// Token: 0x06000228 RID: 552 RVA: 0x0001BB44 File Offset: 0x00019D44
		public string GetValue(string key, int index)
		{
			IntPtr intPtr = BootConfigData.GetValueDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(key), index);
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x0400017C RID: 380
		private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

		// Token: 0x0400017D RID: 381
		private static readonly IntPtr NativeMethodInfoPtr_WrapBootConfigData_Private_Static_BootConfigData_IntPtr_0;

		// Token: 0x0400017E RID: 382
		private static readonly BootConfigData.AppendDelegate AppendDelegateField;

		// Token: 0x0400017F RID: 383
		private static readonly BootConfigData.SetDelegate SetDelegateField;

		// Token: 0x04000180 RID: 384
		private static readonly BootConfigData.GetValueDelegate GetValueDelegateField;

		// Token: 0x0200034F RID: 847
		// (Invoke) Token: 0x06002464 RID: 9316
		private delegate void AppendDelegate(IntPtr @this, IntPtr key, IntPtr value);

		// Token: 0x02000350 RID: 848
		// (Invoke) Token: 0x06002466 RID: 9318
		private delegate void SetDelegate(IntPtr @this, IntPtr key, IntPtr value);

		// Token: 0x02000351 RID: 849
		// (Invoke) Token: 0x06002468 RID: 9320
		private delegate IntPtr GetValueDelegate(IntPtr @this, IntPtr key, int index);
	}
}
