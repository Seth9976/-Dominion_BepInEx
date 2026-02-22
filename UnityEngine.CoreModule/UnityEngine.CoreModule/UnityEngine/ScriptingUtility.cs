using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace UnityEngine
{
	// Token: 0x020000BD RID: 189
	public class ScriptingUtility : Object
	{
		// Token: 0x060010FA RID: 4346 RVA: 0x0000A4AE File Offset: 0x000086AE
		// Note: this type is marked as 'beforefieldinit'.
		static ScriptingUtility()
		{
			Il2CppClassPointerStore<ScriptingUtility>.NativeClassPtr = IL2CPP.GetIl2CppClass("UnityEngine.CoreModule.dll", "UnityEngine", "ScriptingUtility");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptingUtility>.NativeClassPtr);
			ScriptingUtility.NativeMethodInfoPtr_IsManagedCodeWorking_Private_Static_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ScriptingUtility>.NativeClassPtr, 100664458);
		}

		// Token: 0x060010FB RID: 4347 RVA: 0x000454D0 File Offset: 0x000436D0
		[CallerCount(0)]
		public unsafe static bool IsManagedCodeWorking()
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ScriptingUtility.NativeMethodInfoPtr_IsManagedCodeWorking_Private_Static_Boolean_0, 0, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060010FC RID: 4348 RVA: 0x0000A4E7 File Offset: 0x000086E7
		public ScriptingUtility(IntPtr pointer)
			: base(pointer)
		{
		}

		// Token: 0x04000CD0 RID: 3280
		private static readonly IntPtr NativeMethodInfoPtr_IsManagedCodeWorking_Private_Static_Boolean_0;

		// Token: 0x020007A7 RID: 1959
		[StructLayout(2)]
		public struct TestClass
		{
			// Token: 0x06002CED RID: 11501 RVA: 0x00015374 File Offset: 0x00013574
			// Note: this type is marked as 'beforefieldinit'.
			static TestClass()
			{
				Il2CppClassPointerStore<ScriptingUtility.TestClass>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<ScriptingUtility>.NativeClassPtr, "TestClass");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ScriptingUtility.TestClass>.NativeClassPtr);
				ScriptingUtility.TestClass.NativeFieldInfoPtr_value = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ScriptingUtility.TestClass>.NativeClassPtr, "value");
			}

			// Token: 0x06002CEE RID: 11502 RVA: 0x000153A8 File Offset: 0x000135A8
			public Object BoxIl2CppObject()
			{
				return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<ScriptingUtility.TestClass>.NativeClassPtr, ref this));
			}

			// Token: 0x04001C9E RID: 7326
			private static readonly IntPtr NativeFieldInfoPtr_value;

			// Token: 0x04001C9F RID: 7327
			[FieldOffset(0)]
			public int value;
		}
	}
}
