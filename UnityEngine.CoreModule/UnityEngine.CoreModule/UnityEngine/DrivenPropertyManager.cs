using System;
using Il2CppInterop.Runtime;

namespace UnityEngine
{
	// Token: 0x02000226 RID: 550
	public class DrivenPropertyManager
	{
		// Token: 0x06001EF5 RID: 7925 RVA: 0x00011C44 File Offset: 0x0000FE44
		public static void RegisterProperty(Object driver, Object target, string propertyPath)
		{
			DrivenPropertyManager.RegisterPropertyPartial(driver, target, propertyPath);
		}

		// Token: 0x06001EF6 RID: 7926 RVA: 0x00011C50 File Offset: 0x0000FE50
		public static void TryRegisterProperty(Object driver, Object target, string propertyPath)
		{
			DrivenPropertyManager.TryRegisterPropertyPartial(driver, target, propertyPath);
		}

		// Token: 0x06001EF7 RID: 7927 RVA: 0x00011C5C File Offset: 0x0000FE5C
		public static void UnregisterProperty(Object driver, Object target, string propertyPath)
		{
			DrivenPropertyManager.UnregisterPropertyPartial(driver, target, propertyPath);
		}

		// Token: 0x06001EF8 RID: 7928 RVA: 0x00011C68 File Offset: 0x0000FE68
		public static void UnregisterProperties(Object driver)
		{
			DrivenPropertyManager.UnregisterPropertiesDelegateField(IL2CPP.Il2CppObjectBaseToPtr(driver));
		}

		// Token: 0x06001EF9 RID: 7929 RVA: 0x00011C7A File Offset: 0x0000FE7A
		public static void RegisterPropertyPartial(Object driver, Object target, string propertyPath)
		{
			DrivenPropertyManager.RegisterPropertyPartialDelegateField(IL2CPP.Il2CppObjectBaseToPtr(driver), IL2CPP.Il2CppObjectBaseToPtr(target), IL2CPP.ManagedStringToIl2Cpp(propertyPath));
		}

		// Token: 0x06001EFA RID: 7930 RVA: 0x00011C98 File Offset: 0x0000FE98
		public static void TryRegisterPropertyPartial(Object driver, Object target, string propertyPath)
		{
			DrivenPropertyManager.TryRegisterPropertyPartialDelegateField(IL2CPP.Il2CppObjectBaseToPtr(driver), IL2CPP.Il2CppObjectBaseToPtr(target), IL2CPP.ManagedStringToIl2Cpp(propertyPath));
		}

		// Token: 0x06001EFB RID: 7931 RVA: 0x00011CB6 File Offset: 0x0000FEB6
		public static void UnregisterPropertyPartial(Object driver, Object target, string propertyPath)
		{
			DrivenPropertyManager.UnregisterPropertyPartialDelegateField(IL2CPP.Il2CppObjectBaseToPtr(driver), IL2CPP.Il2CppObjectBaseToPtr(target), IL2CPP.ManagedStringToIl2Cpp(propertyPath));
		}

		// Token: 0x0400188F RID: 6287
		private static readonly DrivenPropertyManager.UnregisterPropertiesDelegate UnregisterPropertiesDelegateField = IL2CPP.ResolveICall<DrivenPropertyManager.UnregisterPropertiesDelegate>("UnityEngine.DrivenPropertyManager::UnregisterProperties");

		// Token: 0x04001890 RID: 6288
		private static readonly DrivenPropertyManager.RegisterPropertyPartialDelegate RegisterPropertyPartialDelegateField = IL2CPP.ResolveICall<DrivenPropertyManager.RegisterPropertyPartialDelegate>("UnityEngine.DrivenPropertyManager::RegisterPropertyPartial");

		// Token: 0x04001891 RID: 6289
		private static readonly DrivenPropertyManager.TryRegisterPropertyPartialDelegate TryRegisterPropertyPartialDelegateField = IL2CPP.ResolveICall<DrivenPropertyManager.TryRegisterPropertyPartialDelegate>("UnityEngine.DrivenPropertyManager::TryRegisterPropertyPartial");

		// Token: 0x04001892 RID: 6290
		private static readonly DrivenPropertyManager.UnregisterPropertyPartialDelegate UnregisterPropertyPartialDelegateField = IL2CPP.ResolveICall<DrivenPropertyManager.UnregisterPropertyPartialDelegate>("UnityEngine.DrivenPropertyManager::UnregisterPropertyPartial");

		// Token: 0x02000C07 RID: 3079
		// (Invoke) Token: 0x06003600 RID: 13824
		private delegate void UnregisterPropertiesDelegate(IntPtr driver);

		// Token: 0x02000C08 RID: 3080
		// (Invoke) Token: 0x06003602 RID: 13826
		private delegate void RegisterPropertyPartialDelegate(IntPtr driver, IntPtr target, IntPtr propertyPath);

		// Token: 0x02000C09 RID: 3081
		// (Invoke) Token: 0x06003604 RID: 13828
		private delegate void TryRegisterPropertyPartialDelegate(IntPtr driver, IntPtr target, IntPtr propertyPath);

		// Token: 0x02000C0A RID: 3082
		// (Invoke) Token: 0x06003606 RID: 13830
		private delegate void UnregisterPropertyPartialDelegate(IntPtr driver, IntPtr target, IntPtr propertyPath);
	}
}
