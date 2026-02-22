using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;

namespace UnityEngine
{
	// Token: 0x02000003 RID: 3
	public class RemoteConfigSettings : Object
	{
		// Token: 0x06000026 RID: 38 RVA: 0x00002D58 File Offset: 0x00000F58
		// Note: this type is marked as 'beforefieldinit'.
		static RemoteConfigSettings()
		{
			Il2CppClassPointerStore<RemoteConfigSettings>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.UnityAnalyticsModule.dll", "UnityEngine", "RemoteConfigSettings");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<RemoteConfigSettings>.NativeClassPtr);
			RemoteConfigSettings.NativeFieldInfoPtr_m_Ptr = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteConfigSettings>.NativeClassPtr, "m_Ptr");
			RemoteConfigSettings.NativeFieldInfoPtr_Updated = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<RemoteConfigSettings>.NativeClassPtr, "Updated");
			RemoteConfigSettings.NativeMethodInfoPtr_RemoteConfigSettingsUpdated_Internal_Static_Void_RemoteConfigSettings_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<RemoteConfigSettings>.NativeClassPtr, 100663302);
			RemoteConfigSettings.Internal_CreateDelegateField = IL2CPP.ResolveICall<RemoteConfigSettings.Internal_CreateDelegate>("UnityEngine.RemoteConfigSettings::Internal_Create");
			RemoteConfigSettings.Internal_DestroyDelegateField = IL2CPP.ResolveICall<RemoteConfigSettings.Internal_DestroyDelegate>("UnityEngine.RemoteConfigSettings::Internal_Destroy");
			RemoteConfigSettings.QueueConfigDelegateField = IL2CPP.ResolveICall<RemoteConfigSettings.QueueConfigDelegate>("UnityEngine.RemoteConfigSettings::QueueConfig");
			RemoteConfigSettings.SendDeviceInfoInConfigRequestDelegateField = IL2CPP.ResolveICall<RemoteConfigSettings.SendDeviceInfoInConfigRequestDelegate>("UnityEngine.RemoteConfigSettings::SendDeviceInfoInConfigRequest");
			RemoteConfigSettings.AddSessionTagDelegateField = IL2CPP.ResolveICall<RemoteConfigSettings.AddSessionTagDelegate>("UnityEngine.RemoteConfigSettings::AddSessionTag");
			RemoteConfigSettings.ForceUpdateDelegateField = IL2CPP.ResolveICall<RemoteConfigSettings.ForceUpdateDelegate>("UnityEngine.RemoteConfigSettings::ForceUpdate");
			RemoteConfigSettings.WasLastUpdatedFromServerDelegateField = IL2CPP.ResolveICall<RemoteConfigSettings.WasLastUpdatedFromServerDelegate>("UnityEngine.RemoteConfigSettings::WasLastUpdatedFromServer");
			RemoteConfigSettings.GetIntDelegateField = IL2CPP.ResolveICall<RemoteConfigSettings.GetIntDelegate>("UnityEngine.RemoteConfigSettings::GetInt");
			RemoteConfigSettings.GetLongDelegateField = IL2CPP.ResolveICall<RemoteConfigSettings.GetLongDelegate>("UnityEngine.RemoteConfigSettings::GetLong");
			RemoteConfigSettings.GetFloatDelegateField = IL2CPP.ResolveICall<RemoteConfigSettings.GetFloatDelegate>("UnityEngine.RemoteConfigSettings::GetFloat");
			RemoteConfigSettings.GetStringDelegateField = IL2CPP.ResolveICall<RemoteConfigSettings.GetStringDelegate>("UnityEngine.RemoteConfigSettings::GetString");
			RemoteConfigSettings.GetBoolDelegateField = IL2CPP.ResolveICall<RemoteConfigSettings.GetBoolDelegate>("UnityEngine.RemoteConfigSettings::GetBool");
			RemoteConfigSettings.HasKeyDelegateField = IL2CPP.ResolveICall<RemoteConfigSettings.HasKeyDelegate>("UnityEngine.RemoteConfigSettings::HasKey");
			RemoteConfigSettings.GetCountDelegateField = IL2CPP.ResolveICall<RemoteConfigSettings.GetCountDelegate>("UnityEngine.RemoteConfigSettings::GetCount");
			RemoteConfigSettings.GetKeysDelegateField = IL2CPP.ResolveICall<RemoteConfigSettings.GetKeysDelegate>("UnityEngine.RemoteConfigSettings::GetKeys");
			RemoteConfigSettings.GetAsScriptingObjectDelegateField = IL2CPP.ResolveICall<RemoteConfigSettings.GetAsScriptingObjectDelegate>("UnityEngine.RemoteConfigSettings::GetAsScriptingObject");
			RemoteConfigSettings.UseSafeLockDelegateField = IL2CPP.ResolveICall<RemoteConfigSettings.UseSafeLockDelegate>("UnityEngine.RemoteConfigSettings::UseSafeLock");
			RemoteConfigSettings.ReleaseSafeLockDelegateField = IL2CPP.ResolveICall<RemoteConfigSettings.ReleaseSafeLockDelegate>("UnityEngine.RemoteConfigSettings::ReleaseSafeLock");
			RemoteConfigSettings.GetSafeTopMapDelegateField = IL2CPP.ResolveICall<RemoteConfigSettings.GetSafeTopMapDelegate>("UnityEngine.RemoteConfigSettings::GetSafeTopMap");
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002EE4 File Offset: 0x000010E4
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 123574, XrefRangeEnd = 123577, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static void RemoteConfigSettingsUpdated(RemoteConfigSettings rcs, bool wasLastUpdatedFromServer)
		{
			IntPtr* ptr;
			checked
			{
				ptr = stackalloc IntPtr[unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(rcs);
			}
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref wasLastUpdatedFromServer;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(RemoteConfigSettings.NativeMethodInfoPtr_RemoteConfigSettingsUpdated_Internal_Static_Void_RemoteConfigSettings_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0000215C File Offset: 0x0000035C
		public RemoteConfigSettings(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000029 RID: 41 RVA: 0x00002F28 File Offset: 0x00001128
		// (set) Token: 0x0600002A RID: 42 RVA: 0x00002165 File Offset: 0x00000365
		public unsafe IntPtr m_Ptr
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteConfigSettings.NativeFieldInfoPtr_m_Ptr);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteConfigSettings.NativeFieldInfoPtr_m_Ptr)) = value;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600002B RID: 43 RVA: 0x00002F50 File Offset: 0x00001150
		// (set) Token: 0x0600002C RID: 44 RVA: 0x00002180 File Offset: 0x00000380
		public unsafe Action<bool> Updated
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteConfigSettings.NativeFieldInfoPtr_Updated);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action<bool>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(RemoteConfigSettings.NativeFieldInfoPtr_Updated), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x0600002D RID: 45 RVA: 0x0000219F File Offset: 0x0000039F
		public void add_Updated(Action<bool> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600002E RID: 46 RVA: 0x000021AC File Offset: 0x000003AC
		public void remove_Updated(Action<bool> value)
		{
			throw new NotSupportedException("Method unstripping failed");
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00002F80 File Offset: 0x00001180
		public ~RemoteConfigSettings()
		{
			this.Destroy();
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00002FB0 File Offset: 0x000011B0
		public void Destroy()
		{
			bool flag = this.m_Ptr != IntPtr.Zero;
			if (flag)
			{
				RemoteConfigSettings.Internal_Destroy(this.m_Ptr);
				this.m_Ptr = IntPtr.Zero;
			}
		}

		// Token: 0x06000031 RID: 49 RVA: 0x000021B9 File Offset: 0x000003B9
		public void Dispose()
		{
			this.Destroy();
			GC.SuppressFinalize(this);
		}

		// Token: 0x06000032 RID: 50 RVA: 0x000021CA File Offset: 0x000003CA
		public static IntPtr Internal_Create(RemoteConfigSettings rcs, string configKey)
		{
			return RemoteConfigSettings.Internal_CreateDelegateField(IL2CPP.Il2CppObjectBaseToPtr(rcs), IL2CPP.ManagedStringToIl2Cpp(configKey));
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000021E2 File Offset: 0x000003E2
		public static void Internal_Destroy(IntPtr ptr)
		{
			RemoteConfigSettings.Internal_DestroyDelegateField(ptr);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000021EF File Offset: 0x000003EF
		public static bool QueueConfig(string name, Object param, [Optional] int ver, [Optional] string prefix)
		{
			return RemoteConfigSettings.QueueConfigDelegateField(IL2CPP.ManagedStringToIl2Cpp(name), IL2CPP.Il2CppObjectBaseToPtr(param), ver, IL2CPP.ManagedStringToIl2Cpp(prefix));
		}

		// Token: 0x06000035 RID: 53 RVA: 0x0000220E File Offset: 0x0000040E
		public static bool SendDeviceInfoInConfigRequest()
		{
			return RemoteConfigSettings.SendDeviceInfoInConfigRequestDelegateField();
		}

		// Token: 0x06000036 RID: 54 RVA: 0x0000221A File Offset: 0x0000041A
		public static void AddSessionTag(string tag)
		{
			RemoteConfigSettings.AddSessionTagDelegateField(IL2CPP.ManagedStringToIl2Cpp(tag));
		}

		// Token: 0x06000037 RID: 55 RVA: 0x0000222C File Offset: 0x0000042C
		public void ForceUpdate()
		{
			RemoteConfigSettings.ForceUpdateDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000038 RID: 56 RVA: 0x0000223E File Offset: 0x0000043E
		public bool WasLastUpdatedFromServer()
		{
			return RemoteConfigSettings.WasLastUpdatedFromServerDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002FEC File Offset: 0x000011EC
		public int GetInt(string key)
		{
			return this.GetInt(key, 0);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00002250 File Offset: 0x00000450
		public int GetInt(string key, int defaultValue)
		{
			return RemoteConfigSettings.GetIntDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(key), defaultValue);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00003008 File Offset: 0x00001208
		public long GetLong(string key)
		{
			return this.GetLong(key, 0L);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002269 File Offset: 0x00000469
		public long GetLong(string key, long defaultValue)
		{
			return RemoteConfigSettings.GetLongDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(key), defaultValue);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00003024 File Offset: 0x00001224
		public float GetFloat(string key)
		{
			return this.GetFloat(key, 0f);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002282 File Offset: 0x00000482
		public float GetFloat(string key, float defaultValue)
		{
			return RemoteConfigSettings.GetFloatDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(key), defaultValue);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00003044 File Offset: 0x00001244
		public string GetString(string key)
		{
			return this.GetString(key, "");
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00003064 File Offset: 0x00001264
		public string GetString(string key, string defaultValue)
		{
			IntPtr intPtr = RemoteConfigSettings.GetStringDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(key), IL2CPP.ManagedStringToIl2Cpp(defaultValue));
			return IL2CPP.Il2CppStringToManaged(intPtr);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00003094 File Offset: 0x00001294
		public bool GetBool(string key)
		{
			return this.GetBool(key, false);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x0000229B File Offset: 0x0000049B
		public bool GetBool(string key, bool defaultValue)
		{
			return RemoteConfigSettings.GetBoolDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(key), defaultValue);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000022B4 File Offset: 0x000004B4
		public bool HasKey(string key)
		{
			return RemoteConfigSettings.HasKeyDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.ManagedStringToIl2Cpp(key));
		}

		// Token: 0x06000044 RID: 68 RVA: 0x000022CC File Offset: 0x000004CC
		public int GetCount()
		{
			return RemoteConfigSettings.GetCountDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x06000045 RID: 69 RVA: 0x000030B0 File Offset: 0x000012B0
		public Il2CppStringArray GetKeys()
		{
			IntPtr intPtr = RemoteConfigSettings.GetKeysDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppStringArray>(intPtr2) : null;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x000030DC File Offset: 0x000012DC
		public T GetObject<T>([Optional] string key)
		{
			return this.GetObject(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<T>()), key).Cast<T>();
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00003104 File Offset: 0x00001304
		public Object GetObject(Type type, [Optional] string key)
		{
			bool flag = type == null;
			if (flag)
			{
				throw new ArgumentNullException("type");
			}
			bool flag2 = type.IsAbstract || type.IsSubclassOf(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Object>()));
			if (flag2)
			{
				throw new ArgumentException(String.Concat("Cannot deserialize to new instances of type '", type.Name, ".'"));
			}
			return this.GetAsScriptingObject(type, null, key);
		}

		// Token: 0x06000048 RID: 72 RVA: 0x0000316C File Offset: 0x0000136C
		public Object GetObject(string key, Object defaultValue)
		{
			bool flag = defaultValue == null;
			if (flag)
			{
				throw new ArgumentNullException("defaultValue");
			}
			Type type = defaultValue.GetType();
			bool flag2 = type.IsAbstract || type.IsSubclassOf(Type.GetTypeFromHandle(RuntimeReflectionHelper.GetRuntimeTypeHandle<Object>()));
			if (flag2)
			{
				throw new ArgumentException(String.Concat("Cannot deserialize to new instances of type '", type.Name, ".'"));
			}
			return this.GetAsScriptingObject(type, defaultValue, key);
		}

		// Token: 0x06000049 RID: 73 RVA: 0x000031DC File Offset: 0x000013DC
		public Object GetAsScriptingObject(Type t, Object defaultValue, string key)
		{
			IntPtr intPtr = RemoteConfigSettings.GetAsScriptingObjectDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this), IL2CPP.Il2CppObjectBaseToPtr(t), IL2CPP.Il2CppObjectBaseToPtr(defaultValue), IL2CPP.ManagedStringToIl2Cpp(key));
			IntPtr intPtr2 = intPtr;
			return (intPtr2 != 0) ? Il2CppObjectPool.Get<Object>(intPtr2) : null;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x0000321C File Offset: 0x0000141C
		public IDictionary<string, Object> GetDictionary([Optional] string key)
		{
			this.UseSafeLock();
			IDictionary<string, Object> dictionary = RemoteConfigSettingsHelper.GetDictionary(this.GetSafeTopMap(), key);
			this.ReleaseSafeLock();
			return dictionary;
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000022DE File Offset: 0x000004DE
		public void UseSafeLock()
		{
			RemoteConfigSettings.UseSafeLockDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0600004C RID: 76 RVA: 0x000022F0 File Offset: 0x000004F0
		public void ReleaseSafeLock()
		{
			RemoteConfigSettings.ReleaseSafeLockDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002302 File Offset: 0x00000502
		public IntPtr GetSafeTopMap()
		{
			return RemoteConfigSettings.GetSafeTopMapDelegateField(IL2CPP.Il2CppObjectBaseToPtrNotNull(this));
		}

		// Token: 0x04000015 RID: 21
		private static readonly IntPtr NativeFieldInfoPtr_m_Ptr;

		// Token: 0x04000016 RID: 22
		private static readonly IntPtr NativeFieldInfoPtr_Updated;

		// Token: 0x04000017 RID: 23
		private static readonly IntPtr NativeMethodInfoPtr_RemoteConfigSettingsUpdated_Internal_Static_Void_RemoteConfigSettings_Boolean_0;

		// Token: 0x04000018 RID: 24
		private static readonly RemoteConfigSettings.Internal_CreateDelegate Internal_CreateDelegateField;

		// Token: 0x04000019 RID: 25
		private static readonly RemoteConfigSettings.Internal_DestroyDelegate Internal_DestroyDelegateField;

		// Token: 0x0400001A RID: 26
		private static readonly RemoteConfigSettings.QueueConfigDelegate QueueConfigDelegateField;

		// Token: 0x0400001B RID: 27
		private static readonly RemoteConfigSettings.SendDeviceInfoInConfigRequestDelegate SendDeviceInfoInConfigRequestDelegateField;

		// Token: 0x0400001C RID: 28
		private static readonly RemoteConfigSettings.AddSessionTagDelegate AddSessionTagDelegateField;

		// Token: 0x0400001D RID: 29
		private static readonly RemoteConfigSettings.ForceUpdateDelegate ForceUpdateDelegateField;

		// Token: 0x0400001E RID: 30
		private static readonly RemoteConfigSettings.WasLastUpdatedFromServerDelegate WasLastUpdatedFromServerDelegateField;

		// Token: 0x0400001F RID: 31
		private static readonly RemoteConfigSettings.GetIntDelegate GetIntDelegateField;

		// Token: 0x04000020 RID: 32
		private static readonly RemoteConfigSettings.GetLongDelegate GetLongDelegateField;

		// Token: 0x04000021 RID: 33
		private static readonly RemoteConfigSettings.GetFloatDelegate GetFloatDelegateField;

		// Token: 0x04000022 RID: 34
		private static readonly RemoteConfigSettings.GetStringDelegate GetStringDelegateField;

		// Token: 0x04000023 RID: 35
		private static readonly RemoteConfigSettings.GetBoolDelegate GetBoolDelegateField;

		// Token: 0x04000024 RID: 36
		private static readonly RemoteConfigSettings.HasKeyDelegate HasKeyDelegateField;

		// Token: 0x04000025 RID: 37
		private static readonly RemoteConfigSettings.GetCountDelegate GetCountDelegateField;

		// Token: 0x04000026 RID: 38
		private static readonly RemoteConfigSettings.GetKeysDelegate GetKeysDelegateField;

		// Token: 0x04000027 RID: 39
		private static readonly RemoteConfigSettings.GetAsScriptingObjectDelegate GetAsScriptingObjectDelegateField;

		// Token: 0x04000028 RID: 40
		private static readonly RemoteConfigSettings.UseSafeLockDelegate UseSafeLockDelegateField;

		// Token: 0x04000029 RID: 41
		private static readonly RemoteConfigSettings.ReleaseSafeLockDelegate ReleaseSafeLockDelegateField;

		// Token: 0x0400002A RID: 42
		private static readonly RemoteConfigSettings.GetSafeTopMapDelegate GetSafeTopMapDelegateField;

		// Token: 0x0200001C RID: 28
		// (Invoke) Token: 0x06000105 RID: 261
		private delegate IntPtr Internal_CreateDelegate(IntPtr rcs, IntPtr configKey);

		// Token: 0x0200001D RID: 29
		// (Invoke) Token: 0x06000107 RID: 263
		private delegate void Internal_DestroyDelegate(IntPtr ptr);

		// Token: 0x0200001E RID: 30
		// (Invoke) Token: 0x06000109 RID: 265
		private delegate bool QueueConfigDelegate(IntPtr name, IntPtr param, int ver, IntPtr prefix);

		// Token: 0x0200001F RID: 31
		// (Invoke) Token: 0x0600010B RID: 267
		private delegate bool SendDeviceInfoInConfigRequestDelegate();

		// Token: 0x02000020 RID: 32
		// (Invoke) Token: 0x0600010D RID: 269
		private delegate void AddSessionTagDelegate(IntPtr tag);

		// Token: 0x02000021 RID: 33
		// (Invoke) Token: 0x0600010F RID: 271
		private delegate void ForceUpdateDelegate(IntPtr @this);

		// Token: 0x02000022 RID: 34
		// (Invoke) Token: 0x06000111 RID: 273
		private delegate bool WasLastUpdatedFromServerDelegate(IntPtr @this);

		// Token: 0x02000023 RID: 35
		// (Invoke) Token: 0x06000113 RID: 275
		private delegate int GetIntDelegate(IntPtr @this, IntPtr key, int defaultValue);

		// Token: 0x02000024 RID: 36
		// (Invoke) Token: 0x06000115 RID: 277
		private delegate long GetLongDelegate(IntPtr @this, IntPtr key, long defaultValue);

		// Token: 0x02000025 RID: 37
		// (Invoke) Token: 0x06000117 RID: 279
		private delegate float GetFloatDelegate(IntPtr @this, IntPtr key, float defaultValue);

		// Token: 0x02000026 RID: 38
		// (Invoke) Token: 0x06000119 RID: 281
		private delegate IntPtr GetStringDelegate(IntPtr @this, IntPtr key, IntPtr defaultValue);

		// Token: 0x02000027 RID: 39
		// (Invoke) Token: 0x0600011B RID: 283
		private delegate bool GetBoolDelegate(IntPtr @this, IntPtr key, bool defaultValue);

		// Token: 0x02000028 RID: 40
		// (Invoke) Token: 0x0600011D RID: 285
		private delegate bool HasKeyDelegate(IntPtr @this, IntPtr key);

		// Token: 0x02000029 RID: 41
		// (Invoke) Token: 0x0600011F RID: 287
		private delegate int GetCountDelegate(IntPtr @this);

		// Token: 0x0200002A RID: 42
		// (Invoke) Token: 0x06000121 RID: 289
		private delegate IntPtr GetKeysDelegate(IntPtr @this);

		// Token: 0x0200002B RID: 43
		// (Invoke) Token: 0x06000123 RID: 291
		private delegate IntPtr GetAsScriptingObjectDelegate(IntPtr @this, IntPtr t, IntPtr defaultValue, IntPtr key);

		// Token: 0x0200002C RID: 44
		// (Invoke) Token: 0x06000125 RID: 293
		private delegate void UseSafeLockDelegate(IntPtr @this);

		// Token: 0x0200002D RID: 45
		// (Invoke) Token: 0x06000127 RID: 295
		private delegate void ReleaseSafeLockDelegate(IntPtr @this);

		// Token: 0x0200002E RID: 46
		// (Invoke) Token: 0x06000129 RID: 297
		private delegate IntPtr GetSafeTopMapDelegate(IntPtr @this);
	}
}
